﻿using System;
using CommandLine;
using CommandLine.Text;

namespace Decompiler
{
    class Options
    {
        [Option('i', "input", Required = true,
            HelpText = "Input file to be processed. With no additional arguments, a summary of the input(s) will be displayed.")]
        public string InputFile { get; set; }

        [Option("recursive", DefaultValue = false,
            HelpText = "If specified and given input is a folder, all sub directories will be scanned too.")]
        public bool RecursiveSearch { get; set; }

        [Option('o', "output",
            HelpText = "Writes DATA output to file.")]
        public string OutputFile { get; set; }

        [Option('a', "all",
            HelpText = "Prints the content of each resource block in the file.")]
        public bool PrintAllBlocks { get; set; }

        [Option('b', "block",
            HelpText = "Print the content of a specific block. Specify the block via its 4CC name - case matters! (eg. DATA, RERL, REDI, NTRO).")]
        public string Block { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}