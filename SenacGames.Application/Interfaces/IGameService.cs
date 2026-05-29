using SenacGames.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Application.Interfaces
{
    /// <summary>
    /// Contrato de serviço de Games.
    ///////// Define as operações de negócio disponíveis para o game.
    /// </summary>
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetAllAsync();
        Task<GameDto?> GetByIdAsync(int id);
        Task<IEnumerable<GameDto>> GetFeaturedAsync();
        Task<IEnumerable<GameDto>> GetCategoryAsync(int categoryId);
        Task<GameDto> CreateAsync (CreateGameDto dto);
        Task<GameDto?> UpdateAsync(int id, UpdateGameDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
    //
    //

}
