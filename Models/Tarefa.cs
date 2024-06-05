using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApp.Models
{
    public class Tarefa
    {
        public int Id;
        public string Titulo;
        public string Descricao;
        public bool Concluido;
        public DateTime? Data;
        public int categoriaId;
        public int UsuarioId;
    }
}