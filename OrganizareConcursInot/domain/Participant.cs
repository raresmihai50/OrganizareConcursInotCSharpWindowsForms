using System;
using System.Collections.Generic;

namespace OrganizareConcursInot.domain
{
    public class Participant : Entity<int>

    {
        private int id;
        private string name;
        private int age;
        private List<Trial> trials;

        public Participant(int id, string name, int age, List<Trial> trials)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.trials = trials;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public List<Trial> getTrials()
        {
            return trials;
        }

        public void setTrials(List<Trial> events)
        {
            trials = events;
        }
        public String toString() {
            return "Id=" + id + " " + name + ' ' + age;
        }
    }
}