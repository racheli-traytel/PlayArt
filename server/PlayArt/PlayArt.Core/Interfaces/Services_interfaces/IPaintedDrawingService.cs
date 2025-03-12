﻿using PlayArt.Core.DTOs;
using PlayArt.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayArt.Core.Interfaces.Services_interfaces
{
    public interface IPaintedDrawingService
    {
        IEnumerable<PaintedDrawingDTO> GetList();
        PaintedDrawingDTO GetById(int id);
        Task<PaintedDrawingDTO> AddPaintedDrawingAsync(PaintedDrawingDTO paintedDrawing); // אסינכרוני
        Task<PaintedDrawingDTO> UpdateAsync(int id, PaintedDrawingDTO paintedDrawing); // אסינכרוני
        Task<bool> RemoveAsync(int id); // אסינכרוני
    }
}
