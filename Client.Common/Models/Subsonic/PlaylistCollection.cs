﻿namespace Client.Common.Models.Subsonic
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "playlists", Namespace = "http://subsonic.org/restapi")]
    public class PlaylistCollection
    {
        #region Public Properties

        [XmlElement(ElementName = "playlist", Namespace = "http://subsonic.org/restapi")]
        public List<Playlist> Playlists { get; set; }

        #endregion
    }
}