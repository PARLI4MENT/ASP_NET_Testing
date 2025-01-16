﻿using ToDoList.Domain.Enum;

namespace ToDoList.Domain.Entity
{
    /// <summary>
    /// Приоритет задачи
    /// </summary>
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }

    }
}
