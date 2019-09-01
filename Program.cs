using System;
using Microsoft.EntityFrameworkCore;

namespace SampleRepository {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            // using(var unitOfWork = new UnitOfWork(new SampleContext())) {
            //     var users = unitOfWork.User.GetAll();
            // }
        }
    }
}