﻿using AutoMapper;
using PlayArt.Core.DTOs;
using PlayArt.Core.entities;
using PlayArt.Core.Entities;
using PlayArt.Core.Interfaces;
using PlayArt.Core.Interfaces.IRepositories;
using PlayArt.Core.Interfaces.Services_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayArt.Service
{
    public class DrawingService : IDrawingService
    {
        private readonly IDrawingRepository _repository;
        private readonly IMapper _mapper;

        public DrawingService(IDrawingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<DrawingDTO> GetList()
        {
            return _mapper.Map<IEnumerable<DrawingDTO>>(_repository.GetAllData());
        }

        public DrawingDTO GetById(int id)
        {
            return _mapper.Map<DrawingDTO>(_repository.GetById(id));
        }

        public async Task<DrawingDTO> AddDrawingAsync(DrawingDTO drawing)
        {
            if (_repository.GetById(drawing.Id) == null)
            {
                var result = await _repository.AddAsync(_mapper.Map<Drawing>(drawing));
                return _mapper.Map<DrawingDTO>(result);
            }
            return null;
        }

        public async Task<DrawingDTO> UpdateAsync(int id, DrawingDTO drawing)
        {
            if (id < 0)
                return null;

            var result = await _repository.UpdateAsync(_mapper.Map<Drawing>(drawing), id);
            return _mapper.Map<DrawingDTO>(result);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            if (id < 0) return false;
            return await _repository.DeleteAsync(id);
        }

        public IEnumerable<DrawingDTO> GetDrawingCategory(DrawingCategory? category = null)
        {
            var worksheets = _repository.GetDrawingCategory(category);
            return _mapper.Map<IEnumerable<DrawingDTO>>(worksheets);
        }
    }
}
