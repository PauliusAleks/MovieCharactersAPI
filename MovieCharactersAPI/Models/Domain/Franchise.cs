﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MovieCharactersAPI.Models.Domain
{
    /// <summary>
    /// Domain class for Franchises.
    /// Defining Franchise parameters, navigation properties
    /// and their constraints that will be generated as columns in the Franchise table.
    /// </summary>
    [Table("Franchise")]
    public class Franchise
    {
        //PK
        public int FranchiseId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string? Description { get; set; }

        //Navigation property
        public ICollection<Movie>? Movies { get; set; }
    }
}
