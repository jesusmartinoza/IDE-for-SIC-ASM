//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\SicGrammar.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class SicGrammarLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, RSUB=6, INSTRUCCIONES=7, TIPODIRECTIVA=8, 
		BYTE=9, NUM=10, FINL=11, NUMH=12, NUMHH=13, ID=14, SEP=15;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "RSUB", "INSTRUCCIONES", "TIPODIRECTIVA", 
		"BYTE", "NUM", "FINL", "NUMH", "NUMHH", "ID", "SEP"
	};


	public SicGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SicGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'START'", "'END'", "','", "' '", "'X'", null, null, null, null, 
		null, "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "RSUB", "INSTRUCCIONES", "TIPODIRECTIVA", 
		"BYTE", "NUM", "FINL", "NUMH", "NUMHH", "ID", "SEP"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SicGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SicGrammarLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x11', '\xD3', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 
		'\x36', '\n', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x5', '\a', '>', '\n', '\a', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x5', '\b', '\x8A', '\n', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x5', '\t', 
		'\x98', '\n', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', '\xAC', '\n', '\n', 
		'\x3', '\v', '\x6', '\v', '\xAF', '\n', '\v', '\r', '\v', '\xE', '\v', 
		'\xB0', '\x3', '\v', '\x5', '\v', '\xB4', '\n', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x6', '\r', '\xB9', '\n', '\r', '\r', '\r', '\xE', 
		'\r', '\xBA', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', 
		'\x6', '\xF', '\xC1', '\n', '\xF', '\r', '\xF', '\xE', '\xF', '\xC2', 
		'\x3', '\xF', '\a', '\xF', '\xC6', '\n', '\xF', '\f', '\xF', '\xE', '\xF', 
		'\xC9', '\v', '\xF', '\x6', '\xF', '\xCB', '\n', '\xF', '\r', '\xF', '\xE', 
		'\xF', '\xCC', '\x3', '\x10', '\x6', '\x10', '\xD0', '\n', '\x10', '\r', 
		'\x10', '\xE', '\x10', '\xD1', '\x2', '\x2', '\x11', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '\x3', '\x2', '\x6', '\x4', 
		'\x2', '\x32', ';', '\x43', 'H', '\x4', '\x2', 'J', 'J', 'j', 'j', '\x4', 
		'\x2', '\x43', '\\', '\x63', '|', '\x4', '\x2', '\v', '\v', '\"', '\"', 
		'\x2', '\xF7', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x5', '\'', '\x3', '\x2', '\x2', '\x2', 
		'\a', '+', '\x3', '\x2', '\x2', '\x2', '\t', '-', '\x3', '\x2', '\x2', 
		'\x2', '\v', '/', '\x3', '\x2', '\x2', '\x2', '\r', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\x89', '\x3', '\x2', '\x2', '\x2', '\x11', '\x97', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x99', '\x3', '\x2', '\x2', '\x2', 
		'\x15', '\xAE', '\x3', '\x2', '\x2', '\x2', '\x17', '\xB5', '\x3', '\x2', 
		'\x2', '\x2', '\x19', '\xB8', '\x3', '\x2', '\x2', '\x2', '\x1B', '\xBC', 
		'\x3', '\x2', '\x2', '\x2', '\x1D', '\xCA', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', '\xCF', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\a', 'U', '\x2', 
		'\x2', '\"', '#', '\a', 'V', '\x2', '\x2', '#', '$', '\a', '\x43', '\x2', 
		'\x2', '$', '%', '\a', 'T', '\x2', '\x2', '%', '&', '\a', 'V', '\x2', 
		'\x2', '&', '\x4', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\a', 'G', '\x2', 
		'\x2', '(', ')', '\a', 'P', '\x2', '\x2', ')', '*', '\a', '\x46', '\x2', 
		'\x2', '*', '\x6', '\x3', '\x2', '\x2', '\x2', '+', ',', '\a', '.', '\x2', 
		'\x2', ',', '\b', '\x3', '\x2', '\x2', '\x2', '-', '.', '\a', '\"', '\x2', 
		'\x2', '.', '\n', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', 'Z', 
		'\x2', '\x2', '\x30', '\f', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', 
		'\x5', '\x1D', '\xF', '\x2', '\x32', '\x33', '\x5', '\x1F', '\x10', '\x2', 
		'\x33', '\x36', '\x3', '\x2', '\x2', '\x2', '\x34', '\x36', '\x5', '\x1F', 
		'\x10', '\x2', '\x35', '\x31', '\x3', '\x2', '\x2', '\x2', '\x35', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\x3', '\x2', '\x2', '\x2', 
		'\x36', '\x37', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', 'T', 
		'\x2', '\x2', '\x38', '\x39', '\a', 'U', '\x2', '\x2', '\x39', ':', '\a', 
		'W', '\x2', '\x2', ':', ';', '\a', '\x44', '\x2', '\x2', ';', '=', '\x3', 
		'\x2', '\x2', '\x2', '<', '>', '\x5', '\x1F', '\x10', '\x2', '=', '<', 
		'\x3', '\x2', '\x2', '\x2', '=', '>', '\x3', '\x2', '\x2', '\x2', '>', 
		'\xE', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', '\x43', '\x2', '\x2', 
		'@', '\x41', '\a', '\x46', '\x2', '\x2', '\x41', '\x8A', '\a', '\x46', 
		'\x2', '\x2', '\x42', '\x43', '\a', '\x43', '\x2', '\x2', '\x43', '\x44', 
		'\a', 'P', '\x2', '\x2', '\x44', '\x8A', '\a', '\x46', '\x2', '\x2', '\x45', 
		'\x46', '\a', '\x45', '\x2', '\x2', '\x46', 'G', '\a', 'Q', '\x2', '\x2', 
		'G', 'H', '\a', 'O', '\x2', '\x2', 'H', '\x8A', '\a', 'R', '\x2', '\x2', 
		'I', 'J', '\a', '\x46', '\x2', '\x2', 'J', 'K', '\a', 'K', '\x2', '\x2', 
		'K', '\x8A', '\a', 'X', '\x2', '\x2', 'L', '\x8A', '\a', 'L', '\x2', '\x2', 
		'M', 'N', '\a', 'L', '\x2', '\x2', 'N', 'O', '\a', 'N', '\x2', '\x2', 
		'O', '\x8A', '\a', 'V', '\x2', '\x2', 'P', 'Q', '\a', 'L', '\x2', '\x2', 
		'Q', 'R', '\a', 'I', '\x2', '\x2', 'R', '\x8A', '\a', 'V', '\x2', '\x2', 
		'S', 'T', '\a', 'L', '\x2', '\x2', 'T', 'U', '\a', 'G', '\x2', '\x2', 
		'U', '\x8A', '\a', 'S', '\x2', '\x2', 'V', 'W', '\a', 'L', '\x2', '\x2', 
		'W', 'X', '\a', 'U', '\x2', '\x2', 'X', 'Y', '\a', 'W', '\x2', '\x2', 
		'Y', '\x8A', '\a', '\x44', '\x2', '\x2', 'Z', '[', '\a', 'N', '\x2', '\x2', 
		'[', '\\', '\a', '\x46', '\x2', '\x2', '\\', '\x8A', '\a', '\x43', '\x2', 
		'\x2', ']', '^', '\a', 'N', '\x2', '\x2', '^', '_', '\a', '\x46', '\x2', 
		'\x2', '_', '`', '\a', '\x45', '\x2', '\x2', '`', '\x8A', '\a', 'J', '\x2', 
		'\x2', '\x61', '\x62', '\a', 'N', '\x2', '\x2', '\x62', '\x63', '\a', 
		'\x46', '\x2', '\x2', '\x63', '\x8A', '\a', 'N', '\x2', '\x2', '\x64', 
		'\x65', '\a', 'N', '\x2', '\x2', '\x65', '\x66', '\a', '\x46', '\x2', 
		'\x2', '\x66', '\x8A', '\a', 'Z', '\x2', '\x2', 'g', 'h', '\a', 'O', '\x2', 
		'\x2', 'h', 'i', '\a', 'W', '\x2', '\x2', 'i', '\x8A', '\a', 'N', '\x2', 
		'\x2', 'j', 'k', '\a', 'Q', '\x2', '\x2', 'k', '\x8A', '\a', 'T', '\x2', 
		'\x2', 'l', 'm', '\a', 'T', '\x2', '\x2', 'm', '\x8A', '\a', '\x46', '\x2', 
		'\x2', 'n', 'o', '\a', 'U', '\x2', '\x2', 'o', 'p', '\a', 'V', '\x2', 
		'\x2', 'p', '\x8A', '\a', '\x43', '\x2', '\x2', 'q', 'r', '\a', 'U', '\x2', 
		'\x2', 'r', 's', '\a', 'V', '\x2', '\x2', 's', 't', '\a', '\x45', '\x2', 
		'\x2', 't', '\x8A', '\a', 'J', '\x2', '\x2', 'u', 'v', '\a', 'U', '\x2', 
		'\x2', 'v', 'w', '\a', 'V', '\x2', '\x2', 'w', '\x8A', '\a', 'N', '\x2', 
		'\x2', 'x', 'y', '\a', 'U', '\x2', '\x2', 'y', 'z', '\a', 'V', '\x2', 
		'\x2', 'z', '{', '\a', 'U', '\x2', '\x2', '{', '\x8A', '\a', 'Y', '\x2', 
		'\x2', '|', '}', '\a', 'U', '\x2', '\x2', '}', '~', '\a', 'V', '\x2', 
		'\x2', '~', '\x8A', '\a', 'Z', '\x2', '\x2', '\x7F', '\x80', '\a', 'U', 
		'\x2', '\x2', '\x80', '\x81', '\a', 'W', '\x2', '\x2', '\x81', '\x8A', 
		'\a', '\x44', '\x2', '\x2', '\x82', '\x83', '\a', 'V', '\x2', '\x2', '\x83', 
		'\x8A', '\a', '\x46', '\x2', '\x2', '\x84', '\x85', '\a', 'V', '\x2', 
		'\x2', '\x85', '\x86', '\a', 'K', '\x2', '\x2', '\x86', '\x8A', '\a', 
		'Z', '\x2', '\x2', '\x87', '\x88', '\a', 'Y', '\x2', '\x2', '\x88', '\x8A', 
		'\a', '\x46', '\x2', '\x2', '\x89', '?', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x89', '\x45', '\x3', '\x2', '\x2', 
		'\x2', '\x89', 'I', '\x3', '\x2', '\x2', '\x2', '\x89', 'L', '\x3', '\x2', 
		'\x2', '\x2', '\x89', 'M', '\x3', '\x2', '\x2', '\x2', '\x89', 'P', '\x3', 
		'\x2', '\x2', '\x2', '\x89', 'S', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'V', '\x3', '\x2', '\x2', '\x2', '\x89', 'Z', '\x3', '\x2', '\x2', '\x2', 
		'\x89', ']', '\x3', '\x2', '\x2', '\x2', '\x89', '\x61', '\x3', '\x2', 
		'\x2', '\x2', '\x89', '\x64', '\x3', '\x2', '\x2', '\x2', '\x89', 'g', 
		'\x3', '\x2', '\x2', '\x2', '\x89', 'j', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'l', '\x3', '\x2', '\x2', '\x2', '\x89', 'n', '\x3', '\x2', '\x2', '\x2', 
		'\x89', 'q', '\x3', '\x2', '\x2', '\x2', '\x89', 'u', '\x3', '\x2', '\x2', 
		'\x2', '\x89', 'x', '\x3', '\x2', '\x2', '\x2', '\x89', '|', '\x3', '\x2', 
		'\x2', '\x2', '\x89', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x89', '\x82', 
		'\x3', '\x2', '\x2', '\x2', '\x89', '\x84', '\x3', '\x2', '\x2', '\x2', 
		'\x89', '\x87', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x8B', '\x8C', '\a', 'Y', '\x2', '\x2', '\x8C', '\x8D', 
		'\a', 'Q', '\x2', '\x2', '\x8D', '\x8E', '\a', 'T', '\x2', '\x2', '\x8E', 
		'\x98', '\a', '\x46', '\x2', '\x2', '\x8F', '\x90', '\a', 'T', '\x2', 
		'\x2', '\x90', '\x91', '\a', 'G', '\x2', '\x2', '\x91', '\x92', '\a', 
		'U', '\x2', '\x2', '\x92', '\x98', '\a', '\x44', '\x2', '\x2', '\x93', 
		'\x94', '\a', 'T', '\x2', '\x2', '\x94', '\x95', '\a', 'G', '\x2', '\x2', 
		'\x95', '\x96', '\a', 'U', '\x2', '\x2', '\x96', '\x98', '\a', 'Y', '\x2', 
		'\x2', '\x97', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x97', '\x8F', '\x3', 
		'\x2', '\x2', '\x2', '\x97', '\x93', '\x3', '\x2', '\x2', '\x2', '\x98', 
		'\x12', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\a', '\x44', '\x2', 
		'\x2', '\x9A', '\x9B', '\a', '[', '\x2', '\x2', '\x9B', '\x9C', '\a', 
		'V', '\x2', '\x2', '\x9C', '\x9D', '\a', 'G', '\x2', '\x2', '\x9D', '\x9E', 
		'\x3', '\x2', '\x2', '\x2', '\x9E', '\xAB', '\x5', '\x1F', '\x10', '\x2', 
		'\x9F', '\xA0', '\a', '\x45', '\x2', '\x2', '\xA0', '\xA1', '\a', ')', 
		'\x2', '\x2', '\xA1', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', 
		'\x5', '\x1D', '\xF', '\x2', '\xA3', '\xA4', '\a', ')', '\x2', '\x2', 
		'\xA4', '\xAC', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\a', 'Z', 
		'\x2', '\x2', '\xA6', '\xA7', '\a', ')', '\x2', '\x2', '\xA7', '\xA8', 
		'\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\x5', '\x19', '\r', '\x2', 
		'\xA9', '\xAA', '\a', ')', '\x2', '\x2', '\xAA', '\xAC', '\x3', '\x2', 
		'\x2', '\x2', '\xAB', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xA5', 
		'\x3', '\x2', '\x2', '\x2', '\xAC', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'\xAD', '\xAF', '\t', '\x2', '\x2', '\x2', '\xAE', '\xAD', '\x3', '\x2', 
		'\x2', '\x2', '\xAF', '\xB0', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xAE', 
		'\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\x3', '\x2', '\x2', '\x2', 
		'\xB1', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB4', '\t', '\x3', 
		'\x2', '\x2', '\xB3', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', 
		'\x3', '\x2', '\x2', '\x2', '\xB4', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'\xB5', '\xB6', '\a', '\f', '\x2', '\x2', '\xB6', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\xB7', '\xB9', '\t', '\x2', '\x2', '\x2', '\xB8', '\xB7', 
		'\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', '\x3', '\x2', '\x2', '\x2', 
		'\xBA', '\xB8', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBB', '\x3', '\x2', 
		'\x2', '\x2', '\xBB', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', 
		'\x5', '\x19', '\r', '\x2', '\xBD', '\xBE', '\t', '\x3', '\x2', '\x2', 
		'\xBE', '\x1C', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xC1', '\t', '\x4', 
		'\x2', '\x2', '\xC0', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xC2', 
		'\x3', '\x2', '\x2', '\x2', '\xC2', '\xC0', '\x3', '\x2', '\x2', '\x2', 
		'\xC2', '\xC3', '\x3', '\x2', '\x2', '\x2', '\xC3', '\xC7', '\x3', '\x2', 
		'\x2', '\x2', '\xC4', '\xC6', '\x4', '\x32', ';', '\x2', '\xC5', '\xC4', 
		'\x3', '\x2', '\x2', '\x2', '\xC6', '\xC9', '\x3', '\x2', '\x2', '\x2', 
		'\xC7', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\x3', '\x2', 
		'\x2', '\x2', '\xC8', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xC7', 
		'\x3', '\x2', '\x2', '\x2', '\xCA', '\xC0', '\x3', '\x2', '\x2', '\x2', 
		'\xCB', '\xCC', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCA', '\x3', '\x2', 
		'\x2', '\x2', '\xCC', '\xCD', '\x3', '\x2', '\x2', '\x2', '\xCD', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', '\xCE', '\xD0', '\t', '\x5', '\x2', '\x2', 
		'\xCF', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', '\x3', '\x2', 
		'\x2', '\x2', '\xD1', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD2', 
		'\x3', '\x2', '\x2', '\x2', '\xD2', ' ', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x2', '\x35', '=', '\x89', '\x97', '\xAB', '\xAE', '\xB0', '\xB3', '\xB8', 
		'\xBA', '\xC2', '\xC7', '\xCC', '\xD1', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
