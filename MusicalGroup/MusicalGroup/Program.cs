﻿using MusicalGroup.DataAccess;
using MusicalGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = new Song
            {
                Name = "The show must go on",
                Rating = 8.8,
                Text = "Empty spaces. " +
                "What are we living for?" +
                "Abandoned places." +
                "I guess we know the score." +
                "On and on." +
                "Does anybody know what we are looking for?" +
                "Another hero," +
                "Another mindless crime" +
                "Behind the curtain" +
                "In the pantomime." +
                "Hold the line." +
                "Does anybody want to take it anymore ?" +
                "Show must go on." +
                "Show must go on." +
                "Inside my heart is breaking." +
                "My make - up may be flaking." +
                "But my smile still stays on." +
                "Whatever happens," +
                "I'll leave it all to chance." +
                "Another heartache," +
                "Another failed romance." +
                "On and on." +
                "Does anybody know what we are living for?" +
                "I guess I'm learning." +
                "I must be warmer now." +
                "I'll soon be turning" +
                "'Round the corner now." +
                "Outside the dawn is breaking," +
                "But inside in the dark I'm aching to be free." +
                "Show must go on." +
                "Show must go on." +
                "Inside my heart is breaking." +
                "My make - up may be flaking," +
                "But my smile still stays on." +
                "My soul is painted like the wings of butterflies." +
                "Fairytales of yesterday will grow but never die." +
                "I can fly, my friends." +
                "Show must go on." +
                "Show must go on." +
                "I'll face it with a grin." +
                "I'm never giving in—" +
                "Oh—with the show." +
                "I'll top the bill," +
                "I'll overkill." +
                "I have to find the will to carry on with the show." +
                "On with the show." +
                "Show must go on."
            };
            var group = new Group
            {
                Name = "Queen",
                Songs = new List<Song>() {song}                
            };
            using(var context = new MusicalGroupContext())
            {
                context.Groups.Add(group);
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }
    }
}
