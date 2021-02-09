using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProvoFood.Models
{
    public class SuggestionStorage
    {
        // This class is for user submitted suggestions
        [Required]
        public string PerName { get; set; }
        [Required]
        public string RestName { get; set; }
        public string FavDish { get; set; }
        [Required]
        public string RestPhone { get; set; }

        public static List<SuggestionStorage> suggestions = new List<SuggestionStorage>();
        public static IEnumerable<SuggestionStorage> Suggestions => suggestions;
        public static void AddSuggestion(SuggestionStorage suggestion)
        {
            suggestions.Add(suggestion);
        }
    }


}
