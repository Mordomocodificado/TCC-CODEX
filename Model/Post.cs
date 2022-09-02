using System;
using System.Collections.Generic;

namespace TCC_CODEX.Model
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Publicante { get; set; } = null!;
        public string Conteudo { get; set; } = null!;
        public DateTime Momento { get; set; }
    }
}
