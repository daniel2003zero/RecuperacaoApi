﻿using Microsoft.EntityFrameworkCore;
namespace Sistema_De_Tarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

    }
}
