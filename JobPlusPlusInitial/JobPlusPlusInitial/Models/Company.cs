using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobPlusPlusInitial.Models
{
    public class Company
    {
        #region Fields

        public int CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public int TechnologyLevelId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool IsActive { get; set; }

        #endregion
        #region Constructors
        public Company()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.LastUpdateDate = DateTime.UtcNow;
        }
        #endregion
    }
}
