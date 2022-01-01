using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    [Table("User")]
    public class User
    {
        //         CREATE TABLE [User] (
        //     [Id] INT NOT NULL IDENTITY(1, 1),
        //     [Name] NVARCHAR(80) NOT NULL,
        //     [Email] VARCHAR(200) NOT NULL,
        //     [PasswordHash] VARCHAR(255) NOT NULL,
        //     [Bio] TEXT NOT NULL,
        //     [Image] VARCHAR(2000) NOT NULL,
        //     [Slug] VARCHAR(80) NOT NULL,

        //     CONSTRAINT [PK_User] PRIMARY KEY([Id]),
        //     CONSTRAINT [UQ_User_Email] UNIQUE([Email]),
        //     CONSTRAINT [UQ_User_Slug] UNIQUE([Slug])
        // )
        // CREATE NONCLUSTERED INDEX [IX_User_Email] ON [User]([Email])
        // CREATE NONCLUSTERED INDEX [IX_User_Slug] ON [User]([Slug])

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
        [MaxLength(200)]
        [Column("Email", TypeName = "NVARCHAR")]
        public string? Email { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        [Column("PasswordHash", TypeName = "NVARCHAR")]
        public string? PasswordHash { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(2000)]
        [Column("Image", TypeName = "NVARCHAR")]
        public string? Image { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "NVARCHAR")]
        public string? Slug { get; set; }

        [Required]
        [Column("Bio", TypeName = "TEXT")]
        public string? Bio { get; set; }
    }
}