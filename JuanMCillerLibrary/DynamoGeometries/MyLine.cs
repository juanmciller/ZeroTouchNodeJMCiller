using Autodesk.DesignScript.Geometry;
using ProtoCore.AST.AssociativeAST;
using System.Net.NetworkInformation;

namespace DynamoGeometries
{
    /// <summary>
    /// Represents a line segment defined by two points.
    /// </summary>
    public class MyLine
    {
        // Private fields to store start point, end point, mid point, line segment, and length.
        private Point _startPoint;
        private Point _endPoint;
        private Point _midPoint;
        private Line _mySegment;
        private double _length;

        /// <summary>
        /// Gets or sets the start point of the line segment.
        /// </summary>
        public Point StartPoint
        {
            get { return _startPoint; }
            set { _startPoint = value; }
        }

        /// <summary>
        /// Gets or sets the end point of the line segment.
        /// </summary>
        public Point EndPoint
        {
            get { return _endPoint; }
            set
            {
                // Checking if the new end point has a non-zero Z coordinate.
                // If it does, the end point remains unchanged.
                if (value.Z != 0)
                {
                    _endPoint = EndPoint;
                }
                else
                {
                    _endPoint = value;
                }
            }
        }

        /// <summary>
        /// Gets the midpoint of the line segment.
        /// </summary>
        public Point MidPoint
        {
            get { return _midPoint; }
            set { _midPoint = value; }
        }

        /// <summary>
        /// Gets or sets the line segment.
        /// </summary>
        public Line MySegment
        {
            get { return _mySegment; }
            set { _mySegment = value; }
        }

        /// <summary>
        /// Gets or sets the length of the line segment.
        /// </summary>
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        /// Constructs a new instance of MyLine.
        /// </summary>
        /// <param name="startPoint">The start point of the line segment.</param>
        /// <param name="endPoint">The end point of the line segment.</param>
        private MyLine(Point startPoint, Point endPoint)
        {
            // Assigning the start point and end point.
            _startPoint = startPoint;
            _endPoint = endPoint;

            // Creating the line segment and calculating the mid point.
            _mySegment = Line.ByStartPointEndPoint(startPoint, endPoint);
            _midPoint = _mySegment.PointAtParameter(0.5);

            // Calculating the length of the line segment.
            _length = _mySegment.Length;
        }

        /// <summary>
        /// Creates a new instance of MyLine with specified start and end points.
        /// </summary>
        /// <param name="startPoint">The start point of the line segment.</param>
        /// <param name="endPoint">The end point of the line segment.</param>
        /// <returns>A new instance of MyLine.</returns>
        public static MyLine CreateLine(Point startPoint, Point endPoint)
        {
            // Creating a new instance of MyLine.
            return new MyLine(startPoint, endPoint);
        }
        /// <summary>
        /// Creates a perpendicular line at the specified parameter on the given line.
        /// </summary>
        /// <param name="myLine">The original line.</param>
        /// <param name="myParameter">The parameter on the original line where the perpendicular line is to be obtained.</param>
        /// <param name="length">The length of the perpendicular line (default is 1).</param>
        /// <returns>A new MyLine object representing the perpendicular line.</returns>
        public static MyLine CreatePerpendicularAtParameter(Line myLine, double myParameter, double length = 1)
        {
            // Get the normal vector of the original line at the specified parameter
            Vector perpendicular_vector = myLine.NormalAtParameter(myParameter);

            // Get the point on the original line at the specified parameter
            Point startPoint = myLine.PointAtParameter(myParameter);

            // Create a new line starting from the specified point in the direction of the perpendicular vector
            // with the specified length
            Line line = Line.ByStartPointDirectionLength(startPoint, perpendicular_vector, length);
            Point start_point = line.StartPoint;
            Point end_point = line.EndPoint;

            // Create a new MyLine object from the start and end points of the newly created line
            return new MyLine(start_point, end_point);
        }

        /// <summary>
        /// Gets the length of the specified line segment.
        /// </summary>
        /// <param name="mySegment">The line segment.</param>
        /// <returns>The length of the line segment.</returns>
        public static double GetSegmentLength(MyLine mySegment)
        {
            return mySegment.MySegment.Length;
        }

        /// <summary>
        /// Sets the end point of the specified line segment.
        /// </summary>
        /// <param name="mySegment">The line segment.</param>
        /// <param name="newEndPoint">The new end point.</param>
        /// <returns>The updated line segment.</returns>
        public static Geometry SetSegmentEndPoint(MyLine mySegment, Point newEndPoint)
        {
            // Setting the new end point.
            mySegment.EndPoint = newEndPoint;
            // Recalculating the line segment based on the updated start and end points.
            mySegment.MySegment = Line.ByStartPointEndPoint(mySegment.StartPoint, mySegment.EndPoint);
            return mySegment.MySegment;
        }
    }
}
