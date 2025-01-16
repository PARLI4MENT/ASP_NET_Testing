using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Enum
{
    /// <summary>
    /// Приоритет задач
    /// </summary>
    public enum Priority
    {
        [Display(Name = "Простая")]
        Easy = 0,

        [Display(Name = "Средняя")]
        Medium = 1,

        [Display(Name = "Высокая")]
        High = 2
    }
}