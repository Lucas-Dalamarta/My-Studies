using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int id { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = " Campo obrigatório!")]
        public string Descricao { get; set; }
        
        [Range(1,100,ErrorMessage ="Valor máximo excedido!")]
        public int Quantidade { get; set; }

        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
