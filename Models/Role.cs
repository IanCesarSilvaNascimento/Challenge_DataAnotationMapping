using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    //     CREATE TABLE [Role] (
    //     [Id] INT NOT NULL IDENTITY(1, 1),
    //     [Name] VARCHAR(80) NOT NULL,
    //     [Slug] VARCHAR(80) NOT NULL,

    //     CONSTRAINT [PK_Role] PRIMARY KEY([Id]),
    //     CONSTRAINT [UQ_Role_Slug] UNIQUE([Slug])
    // )
    // CREATE NONCLUSTERED INDEX [IX_Role_Slug] ON [Role]([Slug])

    [Table("Role")]
    public class Role
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