using API_lab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_lab.Data
{
    public class TrackContext:DbContext
    {
        public TrackContext(DbContextOptions<TrackContext> options) : base(options)
        {

        }

        public DbSet<Track> Tracks { get; set; }
    }
}
