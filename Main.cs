using System;
using System.Collections.Generic;
using Flow.Launcher.Plugin;

namespace Flow.Launcher.Plugin.whitespaces
{
    public class whitespaces : IPlugin
    {
        private PluginInitContext _context;

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            bool EndsWithSpace = query.Search.EndsWith(" ");
            string LastChar;
            if (query.Search.Length > 0)
            {
                LastChar = query.Search[^1].ToString();
            }
            else
            {
                LastChar = "Nan";
            }
            List<Result> Results = new List<Result>();
            Results.Add(new Result
            {
                Title = "Is WhiteSpace: " + EndsWithSpace.ToString(),
                SubTitle = "Last Char: " + LastChar
            });
            Results.Add(new Result
            {
                Title = "Ends with the letter a : " + query.Search.EndsWith("a").ToString(),
                SubTitle = "Last Char: " + LastChar
            });
            return Results;
        }
    }
}