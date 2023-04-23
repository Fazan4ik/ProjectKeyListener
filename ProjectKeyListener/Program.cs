using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKeyListener
{
    public class KeyListener
    {
        public event Action EnterKeyPressed;
        public event Action SpaceKeyPressed;
        public event Action EscapeKeyPressed;
        public event Action F1KeyPressed;
        public event Action LeftArrowKeyPressed;
        public event Action RightArrowKeyPressed;
        public event Action UpArrowKeyPressed;
        public event Action DownArrowKeyPressed;

        public void Listen()
        {
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        EnterKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.Spacebar:
                        SpaceKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.Escape:
                        EscapeKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.F1:
                        F1KeyPressed?.Invoke();
                        break;
                    case ConsoleKey.LeftArrow:
                        LeftArrowKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.RightArrow:
                        RightArrowKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.UpArrow:
                        UpArrowKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.DownArrow:
                        DownArrowKeyPressed?.Invoke();
                        break;
                }
            }
        }
    }
    public class Person
    {
        public void Escape()
        {
            Console.WriteLine("Escape method is called");
        }
        public void F1()
        {
            Console.WriteLine("F1 method is called");
        }
        public void Jump()
        {
            Console.WriteLine("Jump method is called");
        }

        public void Select()
        {
            Console.WriteLine("Select method is called");
        }

        public void Move()
        {
            Console.WriteLine("Move method is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listener = new KeyListener();
            var person = new Person();

            listener.EscapeKeyPressed += person.Escape;
            listener.F1KeyPressed += person.F1;
            listener.SpaceKeyPressed += person.Jump;
            listener.EnterKeyPressed += person.Select;
            listener.LeftArrowKeyPressed += person.Move;
            listener.RightArrowKeyPressed += person.Move;
            listener.UpArrowKeyPressed += person.Move;
            listener.DownArrowKeyPressed += person.Move;

            listener.Listen();
        }
    }
}
