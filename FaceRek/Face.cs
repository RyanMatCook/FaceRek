using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FaceRek
{
	public class Face
	{
		public Rectangle Rectangle
		{
			get
			{
				return _rectangle;
			}
			set
			{
				if(value == null)
				{
					_isLocked = false;
					_rectangle = new Rectangle();
				}
				else
				{
					_isLocked = true;
					_rectangle = value;
				}
			}
		}
		private Rectangle _rectangle;


		private bool _isLocked;
	}
}
