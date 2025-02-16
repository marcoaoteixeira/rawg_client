﻿using System.Collections.ObjectModel;

namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// A <see cref="IReadOnlyCollection{T}"/> implementation for <see cref="TrailerOption"/>
    /// </summary>
    public sealed class TrailerOptionCollection : ReadOnlyCollection<TrailerOption> {
        /// <summary>
        /// Initializes a new instance of <see cref="TrailerOptionCollection"/>
        /// </summary>
        public TrailerOptionCollection()
            : base([]) { }

        /// <summary>
        /// Initializes a new instance of <see cref="TrailerOptionCollection"/>
        /// </summary>
        /// <param name="list">The initial list.</param>
        public TrailerOptionCollection(IList<TrailerOption> list)
            : base(list) { }
    }
}
