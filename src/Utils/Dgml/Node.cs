﻿using System.Xml.Serialization;

namespace Utils.Dgml
{
    public struct Node
    {
        /// <summary>
        /// Unique id for the node
        /// </summary>
        [XmlAttribute]
        public string Id;

        /// <summary>
        /// Label for the node
        /// </summary>
        [XmlAttribute]
        public string Label;

        /// <summary>
        /// Creates a new <see cref="Node"/>
        /// </summary>
        /// <param name="id">Id for node</param>
        /// <param name="label">Label for node</param>
        public Node(string id, string label)
        {
            Id = id;
            Label = label;
        }
    }
}
