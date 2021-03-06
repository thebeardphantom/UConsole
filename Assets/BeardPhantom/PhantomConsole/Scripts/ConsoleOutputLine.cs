﻿using UnityEngine;

namespace BeardPhantom.PhantomConsole
{
    /// <summary>
    /// Provides abstract access to a UI based label
    /// </summary>
    public abstract class ConsoleOutputLine : MonoBehaviour
    {
        /// <summary>
        /// Get/set access to the label's current text value
        /// </summary>
        public abstract string Text { get; set; }

        /// <summary>
        /// Get/set access to the label's tint
        /// </summary>
        public abstract Color Color { get; set; }
    }
}