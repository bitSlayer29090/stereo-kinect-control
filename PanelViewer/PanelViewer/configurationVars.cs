/********************************************************************
*   configurationVars.cs											*
*   Copyright (C) 2012 Marquette University & David Quam			*
*	Created on 12 Jan 2012 by David J. Quam							*
*																	*
*	All software is provided "as is" without warranty				*
********************************************************************/
namespace PanelViewer
{
	public class configurationVars
	{
		private int steadyReq;
		private float steadyStddevReq;
		private float swipeVelmin;
		private int swipeXangle;
		private int swipeYangle;
		private int swipeMinDuration;
		private bool swipeUseSteady;
		private int swipeSteadyDur;
		private int circleRadMin;
		private int circleMaxError;
		private float sliderWidth;
		private float sliderHeight;

		#region configurableValues
		public int SteadyReq
		{
			get
			{
				return steadyReq;
			}
			set
			{
				steadyReq = value;
			}
		}
		public float SteadyStddevReq
		{
			get
			{
				return steadyStddevReq;
			}
			set
			{
				steadyStddevReq = value;
			}
		}
		public float SwipeVelmin
		{
			get
			{
				return swipeVelmin;
			}
			set
			{
				swipeVelmin = value;
			}
		}
		public int SwipeXangle
		{
			get
			{
				return swipeXangle;
			}
			set
			{
				swipeXangle = value;
			}
		}
		public int SwipeYangle
		{
			get
			{
				return swipeYangle;
			}
			set
			{
				swipeYangle = value;
			}
		}
		public int SwipeMinDuration
		{
			get
			{
				return swipeMinDuration;
			}
			set
			{
				swipeMinDuration = value;
			}
		}
		public int CircleRadMin
		{
			get
			{
				return circleRadMin;
			}
			set
			{
				circleRadMin = value;
			}
		}
		public int CircleMaxError
		{
			get
			{
				return circleMaxError;
			}
			set
			{
				circleMaxError = value;
			}
		}
		public float SliderWidth
		{
			get
			{
				return sliderWidth;
			}
			set
			{
				sliderWidth = value;
			}
		}
		public float SliderHeight
		{
			get
			{
				return sliderHeight;
			}
			set
			{
				sliderHeight = value;
			}
		}
		public bool SwipeUseSteady
		{
			get
			{
				return swipeUseSteady;
			}
			set
			{
				swipeUseSteady = value;
			}
		}
		public int SwipeSteadyDur
		{
			get
			{
				return swipeSteadyDur;
			}
			set
			{
				swipeSteadyDur = value;
			}
		}
		#endregion
	}
}