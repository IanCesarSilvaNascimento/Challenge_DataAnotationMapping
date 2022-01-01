using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    //     CREATE TABLE [Post] (
    //     [Id] INT NOT NULL IDENTITY(1, 1),
    //     [CategoryId] INT NOT NULL,
    //     [AuthorId] INT NOT NULL,
    //     [Title] VARCHAR(160) NOT NULL,
    //     [Summary] VARCHAR(255) NOT NULL,
    //     [Body] TEXT NOT NULL,
    //     [Slug] VARCHAR(80) NOT NULL,
    //     [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    //     [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),

    //     CONSTRAINT [PK_Post] PRIMARY KEY([Id]),
    //     CONSTRAINT [FK_Post_Category] FOREIGN KEY([CategoryId]) REFERENCES [Category]([Id]),
    //     CONSTRAINT [UQ_Post_Slug] UNIQUE([Slug])
    // )
    // CREATE NONCLUSTERED INDEX [IX_Post_Slug] ON [Post]([Slug])

    [Table("Post")]

    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
               
        [Required]
        [MinLength(3)]
        [MaxLength(160)]
        [Column("Title", TypeName = "NVARCHAR")]
        public string? Title { get; set; }
        
        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        [Column("Summary", TypeName = "NVARCHAR")]
        public string? Summary { get; set; }
        
        [Required]
        [Column("Body", TypeName = "TEXT")]
        public string? Body { get; set; }
        
        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "NVARCHAR")]
        public string? Slug { get; set; }

        [Required]
        [Column("CreateDate",TypeName = "DateTime")]
        public DateTime CreateDate { get; set; }

        
        [Required]
        [Column("LastUpdateDate",TypeName = "DateTime")]
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? category { get; set; }
 
    }
}