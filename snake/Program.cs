using System;
using System.Collections.Generic;

namespace ConsoleGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }
  }

  // position class: handle 2d coords
  public class Position
  {
    public int left;
    public int top;
  }

  // snake class
  public class Snake
  {
    // fields
    private int _length = 6;

    // snake body position
    private List<Position> _points = new List<Position>();

    // getters and setters
    public int Length
    {
      get
      {
        return _length;
      }

      set
      {
        _length = value;
      }
    }

    public List<Position> Points
    {
      get
      {
        return _points;
      }

      //   set => _points = value; <- can also be written like this!
      set
      {
        _points = value;
      }
    }

    // methods
    // check if the snake overlaps with itself
    public bool IfOverlapped(Position currentPos)
    {
      //   for (int i = 0; i < _points.Count; i++)
      //   {
      //     if ((_points[i].left == currentPos.left) && (_points[i].top == currentPos.top))
      //     {
      //       return true;
      //     }
      //   }
      return false;
    }

    public Position SetInitialPosition()
    {
      return new Position()
      {
        left = 0,
        top = 0
      };
    }
  }

  // food class

}
