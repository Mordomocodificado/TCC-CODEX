﻿using System;
using System.Collections.Generic;

namespace TCC_CODEX.Model
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string Senha { get; set; } = null!;
    }
}
