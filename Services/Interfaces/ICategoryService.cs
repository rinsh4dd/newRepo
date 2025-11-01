﻿using ShoeCartBackend.DTOs.CategoryDTO;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetAllAsync();
    Task<CategoryDTO?> GetByIdAsync(int id);
    Task<CategoryDTO> AddAsync(CategoryDTO dto);
    Task<CategoryDTO?> UpdateAsync(int id, CategoryDTO dto);
    Task<bool> DeleteAsync(int id);
}
