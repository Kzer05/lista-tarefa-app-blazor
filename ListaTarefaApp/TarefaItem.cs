using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTarefaApp
{
    public class TarefaItem
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool FlagFeito { get; set; }
        public DateTime DataCriacao { get; set; }       
    }
}
