using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogoAPI.Models
{
    [Table("Categorias")] //redundante
    public class Categoria
    {     
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key] //redundante
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }
        [JsonIgnore]
        public ICollection<Produto>? Produtos { get; set; }
    }
}