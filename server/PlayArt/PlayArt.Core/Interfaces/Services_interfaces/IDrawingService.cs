﻿using PlayArt.Core.DTOs;
using PlayArt.Core.entities;
using PlayArt.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayArt.Core.Interfaces.Services_interfaces
{
    public interface IDrawingService
    {
        IEnumerable<DrawingDTO> GetList();
        DrawingDTO GetById(int id);
        Task<DrawingDTO> AddDrawingAsync(DrawingDTO drawing); // אסינכרוני
        Task<DrawingDTO> UpdateAsync(int id, DrawingDTO drawing); // אסינכרוני
        Task<bool> RemoveAsync(int id); // אסינכרוני
        IEnumerable<DrawingDTO> GetDrawingCategory(DrawingCategory? category = null);
    }
}
