﻿namespace MOQ_Exercise.DAL
{
    public interface IRepository<T> where T : class
    {
        // CREATE
        void Add(T entity);


        // READ
        T Get(int id);
        T Get(Func<T, bool> predicate);
        ICollection<T> GetAll();
        ICollection<T> GetList(Func<T, bool> predicate);
        ICollection<T> GetTop3SalariedEmployees();

        // UPDATE
        T Update(T entity);

        // DELETE
        void Delete(T entity);

        void Save();
    }
}
