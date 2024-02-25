using Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Runtime;
using System.Collections.Generic;

namespace DynamoGeometries
{
    /// <summary>
    /// Represents a class to create a point in Dynamo.
    /// </summary>
    public class CreatePoint
    {
        private Point _mypoint;
        private double _xCoord;
        private double _yCoord;
        private double _zCoord;

        /// <summary>
        /// Gets or sets the point.
        /// </summary>
        public Point MyPoint
        {
            get { return _mypoint; }
            set { _mypoint = value; }
        }

        /// <summary>
        /// Gets or sets the x-coordinate.
        /// </summary>
        public double XCoord
        {
            get { return _xCoord; }
            set { _xCoord = value; }
        }

        /// <summary>
        /// Gets or sets the y-coordinate.
        /// </summary>
        public double YCoord
        {
            get { return _yCoord; }
            set { _yCoord = value; }
        }

        /// <summary>
        /// Gets or sets the z-coordinate.
        /// </summary>
        public double ZCoord
        {
            get { return _zCoord; }
            set { _zCoord = value; }
        }

        /// <summary>
        /// Private constructor to create a point.
        /// </summary>
        /// <param name="xCoord">The x coordinate.</param>
        /// <param name="yCoord">The y coordinate.</param>
        /// <param name="zCoord">The z coordinate.</param>
        private CreatePoint(double xCoord, double yCoord, double zCoord)
        {
            _xCoord = xCoord;
            _yCoord = yCoord;
            _zCoord = zCoord;
            MyPoint = Point.ByCoordinates(xCoord, yCoord, zCoord);
        }

        /// <summary>
        /// Creates a new instance of the CreatePoint class.
        /// </summary>
        /// <param name="xCoord">The x coordinate of the point. Default is 0.</param>
        /// <param name="yCoord">The y coordinate of the point. Default is 0.</param>
        /// <param name="zCoord">The z coordinate of the point. Default is 0.</param>
        /// <returns>A CreatePoint object.</returns>
        public static CreatePoint CreateMyPoint(double xCoord = 0, double yCoord = 0, double zCoord = 0)
        {
            return new CreatePoint(xCoord, yCoord, zCoord);
        }

        /// <summary>
        /// Deconstructs a point into its individual coordinates.
        /// </summary>
        /// <param name="point">The point to be deconstructed.</param>
        /// <returns>A dictionary containing the X, Y, and Z coordinates of the point.</returns>
        [MultiReturn(new[] { "X", "Y", "Z" })]
        public static Dictionary<string, object> DeconstructPoint(Point point)
        {
            // Create a dictionary to store the coordinates
            return new Dictionary<string, object> {
                // Add X coordinate to the dictionary
                { "X", point.X },
                // Add Y coordinate to the dictionary
                { "Y", point.Y },
                // Add Z coordinate to the dictionary
                { "Z", point.Z }
            };
        }
    }
}
