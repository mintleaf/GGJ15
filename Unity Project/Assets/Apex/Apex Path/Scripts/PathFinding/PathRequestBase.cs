﻿/* Copyright © 2014 Apex Software. All rights reserved. */
namespace Apex.PathFinding
{
    using Apex.Units;
    using Apex.WorldGeometry;
    using UnityEngine;

    /// <summary>
    /// Base class for path request types.
    /// </summary>
    public abstract class PathRequestBase
    {
        /// <summary>
        /// Gets or sets where to move from.
        /// </summary>
        public Vector3 from
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets where to move to.
        /// </summary>
        public Vector3 to
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the grid on which the navigation starts. Do not set this explicitly, the engine handles that.
        /// </summary>
        public IGrid fromGrid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets to grid.
        /// </summary>
        /// <value>
        /// To grid.
        /// </value>
        public IGrid toGrid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the requester of this path, i.e. the entity that needs a path.
        /// </summary>
        public virtual INeedPath requester
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the type of this request.
        /// </summary>
        public RequestType type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the maximum escape cell distance if origin blocked.
        /// This means that when starting a path and the origin (from position) is blocked, this determines how far away the pather will look for a free cell to escape to, before resuming the planned path.
        /// </summary>
        /// <value>
        /// The maximum escape cell distance if origin blocked.
        /// </value>
        public int maxEscapeCellDistanceIfOriginBlocked
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether to use path smoothing.
        /// Path smoothing creates more natural routes at a small cost to performance.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to path smoothing; otherwise, <c>false</c>.
        /// </value>
        public bool usePathSmoothing
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether to allow the path to cut corners. Corner cutting has slightly better performance, but produces less natural routes.
        /// </summary>
        public bool allowCornerCutting
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether navigation off-grid is prohibited.
        /// </summary>
        public bool preventOffGridNavigation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether diagonal moves are prohibited.
        /// </summary>
        /// <value>
        /// <c>true</c> if diagonal moves are prohibited; otherwise, <c>false</c>.
        /// </value>
        public bool preventDiagonalMoves
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether the unit will navigate to the nearest possible position if the actual destination is blocked or otherwise inaccessible.
        /// </summary>
        public bool navigateToNearestIfBlocked
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pending way points that are not covered by this request. Do not set this explicitly, the engine handles that.
        /// </summary>
        /// <value>
        /// The pending way points.
        /// </value>
        public Vector3[] pendingWaypoints
        {
            get;
            set;
        }
    }
}
