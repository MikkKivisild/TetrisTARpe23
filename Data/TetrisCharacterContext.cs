﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.core.Domain;

namespace Tetris.Data
{
    public class TetrisCharacterContext
    {
        public class TetrisCharacterContext : DbContext
        {
            public DbSet<Character> Characters { get; set; }
        }
    }
}
