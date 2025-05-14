using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    //추상 클래스
    abstract class Animal : Object
    {       
        private string _name;
        protected int _level;
        protected COLOR _color;

        public string Name { get { return _name; } }
        public int Level { get { return _level; } }
        public COLOR Color { get { return _color; } }

        public Animal(string name, COLOR color)
        {
            this._name = name;
            this._color = color;
        }

        //Object 클래스의 ToString()을
        //override(재정의)한다
        public override string ToString()
        {
            return $"ANIMAL:{_name}";
        }

        //abstract가 붙으면 내용이 있으면 안됨
        abstract protected bool AddLevel(int level);
        
        public virtual void Eat()
        {
            AddLevel(3);
        }
        public void Play()
        {
            AddLevel(2);
        }
    }
}

