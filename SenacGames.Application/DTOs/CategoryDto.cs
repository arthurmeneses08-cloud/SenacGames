using System;
using System.Collections.Generic;
using System.Text;

//DTO CATEGORIA, PARA SER USADO NA HORA DE CADASTRAR UM JOGO. PARA O ÚSUARIO SELECIONAR A CATEGORIA DO JOGO.

namespace SenacGames.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Quantidade de jogos nesta categoria
        /// Utíl para mostrar no deashboard e na listagem
        /// </summary>
        public int GameCount { get; set; }
    }

    /// <summary>
    /// DTO para criação de uma nova categoria
    /// </summary>
    public class CreateCategoryDto
    {
        public string Name { get; set; }= string.Empty;

    }

    /// <summary>
    /// DTO para atualização de uma categoria existente.
    /// </summary>
    public class UpdateCategoryDto
    {
        public string Name { get; set; }= string.Empty;
    }

}
