using System;

namespace WorkerProject.Entities
{
    // classe e construtor primario
    //class Department(string name)
    //{

    //    public string Name { get; set; } = name;
    //}


    // classe e construtor
    class Department
    {

        public string Name { get; set; }

        // construtor vazio
        public Department()
        {
        }

        // construtor
        public Department(string name)
        {
            Name = name;
        }
    }
}
