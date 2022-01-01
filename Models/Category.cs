using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{

    //     CREATE TABLE [Category] (
    //     [Id] INT NOT NULL IDENTITY(1, 1),
    //     [Name] VARCHAR(80) NOT NULL,
    //     [Slug] VARCHAR(80) NOT NULL,

    //     CONSTRAINT [PK_Category] PRIMARY KEY([Id]),
    //     CONSTRAINT [UQ_Category_Slug] UNIQUE([Slug])
    // )
    // CREATE NONCLUSTERED INDEX [IX_Category_Slug] ON [Category]([Slug])

    [Table("Category")]
    public class Category
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string? Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "NVARCHAR")]
        public string? Slug { get; set; }
    }
}