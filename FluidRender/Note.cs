﻿/*====================================================*\
 *||          Copyright(c) KineticIsEpic.             ||
 *||          See LICENSE.TXT for details.            ||
 *====================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTOmate;

namespace FluidSys {
    /// <summary>
    /// Represents a single note to be rendered.
    /// </summary>
    public class Note {
        /// <summary>
        /// Gets or sets the sample pack location used to render this note.e
        /// This property is ignored of UseDefaultVb is set to true.
        /// </summary>
        public string VbPath { get; set; }
        /// <summary>
        /// Gets or sets the user-friendly name for this note.
        /// </summary>
        public string DispName { get; set; }
        /// <summary>
        /// Gets or sets the name of the sample used for rendering, path excluded.
        /// Concatenated with VbPath to create a full path (use FullPath for convenience).
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Gets a full file path for the sample to render.
        /// </summary>
        public string FullPath { get { return VbPath + "\\" + FileName; } }
        /// <summary>
        /// Gets or sets the pitch of the note, represented e.g. C#4.
        /// </summary>
        public string NotePitch { get; set; }
        /// <summary>
        /// Gets or set addtional arguments used at render time.
        /// </summary>
        public string Args { get; set; }
        /// <summary>
        /// Gets or sets the Velocity property for this FluidSys.Note.
        /// </summary>
        public int Velocity { get; set; }
        /// <summary>
        /// Gets or sets the Length property for this FluidSys.Note.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// Gets or sets the location of this note in the sheet, 
        /// relative to the positioning of this and the last note.
        /// </summary>
        public int Location { get; set; }
        /// <summary>
        /// Envelopes for Fluid rendering
        /// </summary>
        public int[] Envelope { get; set; }
        /// <summary>
        /// Set to true to use the sample pack path indicated by the 
        /// containing FluidSys.Sheet class at render time.
        /// </summary>
        public bool UseDefaultVb { get; set; }
        /// <summary>
        /// Gets the voice properties of this FluidSys.Note.
        /// </summary>
        public VoiceProp VoiceProperties { get; set; }
        
        /// <summary>
        /// Create a new instance of the FluidSys.Note class using the
        /// specified VoiceProp.
        /// </summary>
        public Note(VoiceProp vProp) {
            UseDefaultVb = true;
            VoiceProperties = vProp;
            Location = 0;
            Length = 1024;
            Velocity = 100;
        }

        /// <summary>
        /// Creates a new instance of the FLuidSys.Note class.
        /// </summary>
        public Note() {
            UseDefaultVb = true;
            VoiceProperties = new VoiceProp();
            Location = 0;
            Length = 1024;
            Velocity = 100;
        }
    }
}
