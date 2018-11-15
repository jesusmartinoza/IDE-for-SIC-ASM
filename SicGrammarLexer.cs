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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, RSUB=8, REG=9, 
		INSTRUNO=10, INSFDOSRN=11, INSFDOSR=12, INSFDOSRR=13, INSTRES=14, TIPODIRECTIVA=15, 
		BYTEOP=16, NUM=17, FINL=18, NUMH=19, NUMHH=20, ID=21, INDEX=22, SEP=23, 
		MODIR=24;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "RSUB", "REG", 
		"INSTRUNO", "INSFDOSRN", "INSFDOSR", "INSFDOSRR", "INSTRES", "TIPODIRECTIVA", 
		"BYTEOP", "NUM", "FINL", "NUMH", "NUMHH", "ID", "INDEX", "SEP", "MODIR"
	};


	public SicGrammarLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SicGrammarLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'START'", "'END'", "'+'", "'BYTE'", "'BASE'", "','", "'SVC'", "'RSUB'", 
		null, null, null, null, null, null, null, null, null, "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "RSUB", "REG", "INSTRUNO", 
		"INSFDOSRN", "INSFDOSR", "INSFDOSRR", "INSTRES", "TIPODIRECTIVA", "BYTEOP", 
		"NUM", "FINL", "NUMH", "NUMHH", "ID", "INDEX", "SEP", "MODIR"
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
		'\x5964', '\x2', '\x1A', '\x165', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x5', '\v', 'l', '\n', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x5', '\f', 'z', '\n', '\f', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x5', '\r', '\x85', '\n', 
		'\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x5', '\xE', 
		'\x9F', '\n', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x5', 
		'\xF', '\x121', '\n', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x5', '\x10', 
		'\x12F', '\n', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x5', '\x11', '\x13D', 
		'\n', '\x11', '\x3', '\x12', '\x6', '\x12', '\x140', '\n', '\x12', '\r', 
		'\x12', '\xE', '\x12', '\x141', '\x3', '\x12', '\x5', '\x12', '\x145', 
		'\n', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x6', '\x14', 
		'\x14A', '\n', '\x14', '\r', '\x14', '\xE', '\x14', '\x14B', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x6', '\x16', '\x152', '\n', 
		'\x16', '\r', '\x16', '\xE', '\x16', '\x153', '\x3', '\x17', '\x3', '\x17', 
		'\a', '\x17', '\x158', '\n', '\x17', '\f', '\x17', '\xE', '\x17', '\x15B', 
		'\v', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x6', '\x18', 
		'\x160', '\n', '\x18', '\r', '\x18', '\xE', '\x18', '\x161', '\x3', '\x19', 
		'\x3', '\x19', '\x2', '\x2', '\x1A', '\x3', '\x3', '\x5', '\x4', '\a', 
		'\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', 
		'\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', 
		'\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', '\x14', 
		'\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', '\x31', 
		'\x1A', '\x3', '\x2', '\b', '\a', '\x2', '\x43', '\x44', 'H', 'H', 'N', 
		'N', 'U', 'V', 'Z', 'Z', '\x4', '\x2', '\x32', ';', '\x43', 'H', '\x4', 
		'\x2', 'J', 'J', 'j', 'j', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x4', 
		'\x2', '\v', '\v', '\"', '\"', '\x4', '\x2', '%', '%', '\x42', '\x42', 
		'\x2', '\x1A1', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x33', '\x3', '\x2', '\x2', '\x2', '\x5', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\a', '=', '\x3', '\x2', '\x2', '\x2', '\t', '?', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x44', '\x3', '\x2', '\x2', '\x2', '\r', 'I', '\x3', 
		'\x2', '\x2', '\x2', '\xF', 'K', '\x3', '\x2', '\x2', '\x2', '\x11', 'O', 
		'\x3', '\x2', '\x2', '\x2', '\x13', 'T', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'k', '\x3', '\x2', '\x2', '\x2', '\x17', 'y', '\x3', '\x2', '\x2', '\x2', 
		'\x19', '\x84', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x9E', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '\x120', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x12E', 
		'\x3', '\x2', '\x2', '\x2', '!', '\x13C', '\x3', '\x2', '\x2', '\x2', 
		'#', '\x13F', '\x3', '\x2', '\x2', '\x2', '%', '\x146', '\x3', '\x2', 
		'\x2', '\x2', '\'', '\x149', '\x3', '\x2', '\x2', '\x2', ')', '\x14D', 
		'\x3', '\x2', '\x2', '\x2', '+', '\x151', '\x3', '\x2', '\x2', '\x2', 
		'-', '\x155', '\x3', '\x2', '\x2', '\x2', '/', '\x15F', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x163', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', 
		'\a', 'U', '\x2', '\x2', '\x34', '\x35', '\a', 'V', '\x2', '\x2', '\x35', 
		'\x36', '\a', '\x43', '\x2', '\x2', '\x36', '\x37', '\a', 'T', '\x2', 
		'\x2', '\x37', '\x38', '\a', 'V', '\x2', '\x2', '\x38', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '\x39', ':', '\a', 'G', '\x2', '\x2', ':', ';', '\a', 
		'P', '\x2', '\x2', ';', '<', '\a', '\x46', '\x2', '\x2', '<', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '=', '>', '\a', '-', '\x2', '\x2', '>', '\b', '\x3', 
		'\x2', '\x2', '\x2', '?', '@', '\a', '\x44', '\x2', '\x2', '@', '\x41', 
		'\a', '[', '\x2', '\x2', '\x41', '\x42', '\a', 'V', '\x2', '\x2', '\x42', 
		'\x43', '\a', 'G', '\x2', '\x2', '\x43', '\n', '\x3', '\x2', '\x2', '\x2', 
		'\x44', '\x45', '\a', '\x44', '\x2', '\x2', '\x45', '\x46', '\a', '\x43', 
		'\x2', '\x2', '\x46', 'G', '\a', 'U', '\x2', '\x2', 'G', 'H', '\a', 'G', 
		'\x2', '\x2', 'H', '\f', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', '.', 
		'\x2', '\x2', 'J', '\xE', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', 
		'U', '\x2', '\x2', 'L', 'M', '\a', 'X', '\x2', '\x2', 'M', 'N', '\a', 
		'\x45', '\x2', '\x2', 'N', '\x10', '\x3', '\x2', '\x2', '\x2', 'O', 'P', 
		'\a', 'T', '\x2', '\x2', 'P', 'Q', '\a', 'U', '\x2', '\x2', 'Q', 'R', 
		'\a', 'W', '\x2', '\x2', 'R', 'S', '\a', '\x44', '\x2', '\x2', 'S', '\x12', 
		'\x3', '\x2', '\x2', '\x2', 'T', 'U', '\t', '\x2', '\x2', '\x2', 'U', 
		'\x14', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', 'H', '\x2', '\x2', 
		'W', 'X', '\a', 'K', '\x2', '\x2', 'X', 'l', '\a', 'Z', '\x2', '\x2', 
		'Y', 'Z', '\a', 'H', '\x2', '\x2', 'Z', '[', '\a', 'N', '\x2', '\x2', 
		'[', '\\', '\a', 'Q', '\x2', '\x2', '\\', ']', '\a', '\x43', '\x2', '\x2', 
		']', 'l', '\a', 'V', '\x2', '\x2', '^', '_', '\a', 'J', '\x2', '\x2', 
		'_', '`', '\a', 'K', '\x2', '\x2', '`', 'l', '\a', 'Q', '\x2', '\x2', 
		'\x61', '\x62', '\a', 'P', '\x2', '\x2', '\x62', '\x63', '\a', 'Q', '\x2', 
		'\x2', '\x63', '\x64', '\a', 'T', '\x2', '\x2', '\x64', 'l', '\a', 'O', 
		'\x2', '\x2', '\x65', '\x66', '\a', 'U', '\x2', '\x2', '\x66', 'g', '\a', 
		'K', '\x2', '\x2', 'g', 'l', '\a', 'Q', '\x2', '\x2', 'h', 'i', '\a', 
		'V', '\x2', '\x2', 'i', 'j', '\a', 'K', '\x2', '\x2', 'j', 'l', '\a', 
		'Q', '\x2', '\x2', 'k', 'V', '\x3', '\x2', '\x2', '\x2', 'k', 'Y', '\x3', 
		'\x2', '\x2', '\x2', 'k', '^', '\x3', '\x2', '\x2', '\x2', 'k', '\x61', 
		'\x3', '\x2', '\x2', '\x2', 'k', '\x65', '\x3', '\x2', '\x2', '\x2', 'k', 
		'h', '\x3', '\x2', '\x2', '\x2', 'l', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'm', 'n', '\a', 'U', '\x2', '\x2', 'n', 'o', '\a', 'J', '\x2', '\x2', 
		'o', 'p', '\a', 'K', '\x2', '\x2', 'p', 'q', '\a', 'H', '\x2', '\x2', 
		'q', 'r', '\a', 'V', '\x2', '\x2', 'r', 'z', '\a', 'T', '\x2', '\x2', 
		's', 't', '\a', 'U', '\x2', '\x2', 't', 'u', '\a', 'J', '\x2', '\x2', 
		'u', 'v', '\a', 'K', '\x2', '\x2', 'v', 'w', '\a', 'H', '\x2', '\x2', 
		'w', 'x', '\a', 'V', '\x2', '\x2', 'x', 'z', '\a', 'N', '\x2', '\x2', 
		'y', 'm', '\x3', '\x2', '\x2', '\x2', 'y', 's', '\x3', '\x2', '\x2', '\x2', 
		'z', '\x18', '\x3', '\x2', '\x2', '\x2', '{', '|', '\a', '\x45', '\x2', 
		'\x2', '|', '}', '\a', 'N', '\x2', '\x2', '}', '~', '\a', 'G', '\x2', 
		'\x2', '~', '\x7F', '\a', '\x43', '\x2', '\x2', '\x7F', '\x85', '\a', 
		'T', '\x2', '\x2', '\x80', '\x81', '\a', 'V', '\x2', '\x2', '\x81', '\x82', 
		'\a', 'K', '\x2', '\x2', '\x82', '\x83', '\a', 'Z', '\x2', '\x2', '\x83', 
		'\x85', '\a', 'T', '\x2', '\x2', '\x84', '{', '\x3', '\x2', '\x2', '\x2', 
		'\x84', '\x80', '\x3', '\x2', '\x2', '\x2', '\x85', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', '\x86', '\x87', '\a', '\x43', '\x2', '\x2', '\x87', '\x88', 
		'\a', '\x46', '\x2', '\x2', '\x88', '\x89', '\a', '\x46', '\x2', '\x2', 
		'\x89', '\x9F', '\a', 'T', '\x2', '\x2', '\x8A', '\x8B', '\a', '\x45', 
		'\x2', '\x2', '\x8B', '\x8C', '\a', 'Q', '\x2', '\x2', '\x8C', '\x8D', 
		'\a', 'O', '\x2', '\x2', '\x8D', '\x8E', '\a', 'R', '\x2', '\x2', '\x8E', 
		'\x9F', '\a', 'T', '\x2', '\x2', '\x8F', '\x90', '\a', '\x46', '\x2', 
		'\x2', '\x90', '\x91', '\a', 'K', '\x2', '\x2', '\x91', '\x92', '\a', 
		'X', '\x2', '\x2', '\x92', '\x9F', '\a', 'T', '\x2', '\x2', '\x93', '\x94', 
		'\a', 'O', '\x2', '\x2', '\x94', '\x95', '\a', 'W', '\x2', '\x2', '\x95', 
		'\x96', '\a', 'N', '\x2', '\x2', '\x96', '\x9F', '\a', 'T', '\x2', '\x2', 
		'\x97', '\x98', '\a', 'T', '\x2', '\x2', '\x98', '\x99', '\a', 'O', '\x2', 
		'\x2', '\x99', '\x9F', '\a', 'Q', '\x2', '\x2', '\x9A', '\x9B', '\a', 
		'U', '\x2', '\x2', '\x9B', '\x9C', '\a', 'W', '\x2', '\x2', '\x9C', '\x9D', 
		'\a', '\x44', '\x2', '\x2', '\x9D', '\x9F', '\a', 'T', '\x2', '\x2', '\x9E', 
		'\x86', '\x3', '\x2', '\x2', '\x2', '\x9E', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x9E', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x9E', '\x93', '\x3', 
		'\x2', '\x2', '\x2', '\x9E', '\x97', '\x3', '\x2', '\x2', '\x2', '\x9E', 
		'\x9A', '\x3', '\x2', '\x2', '\x2', '\x9F', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\xA0', '\xA1', '\a', '\x43', '\x2', '\x2', '\xA1', '\xA2', '\a', 
		'\x46', '\x2', '\x2', '\xA2', '\x121', '\a', '\x46', '\x2', '\x2', '\xA3', 
		'\xA4', '\a', '\x43', '\x2', '\x2', '\xA4', '\xA5', '\a', '\x46', '\x2', 
		'\x2', '\xA5', '\xA6', '\a', '\x46', '\x2', '\x2', '\xA6', '\x121', '\a', 
		'H', '\x2', '\x2', '\xA7', '\xA8', '\a', '\x43', '\x2', '\x2', '\xA8', 
		'\xA9', '\a', 'P', '\x2', '\x2', '\xA9', '\x121', '\a', '\x46', '\x2', 
		'\x2', '\xAA', '\xAB', '\a', '\x45', '\x2', '\x2', '\xAB', '\xAC', '\a', 
		'Q', '\x2', '\x2', '\xAC', '\xAD', '\a', 'O', '\x2', '\x2', '\xAD', '\x121', 
		'\a', 'R', '\x2', '\x2', '\xAE', '\xAF', '\a', '\x45', '\x2', '\x2', '\xAF', 
		'\xB0', '\a', 'Q', '\x2', '\x2', '\xB0', '\xB1', '\a', 'O', '\x2', '\x2', 
		'\xB1', '\xB2', '\a', 'R', '\x2', '\x2', '\xB2', '\x121', '\a', 'H', '\x2', 
		'\x2', '\xB3', '\xB4', '\a', '\x46', '\x2', '\x2', '\xB4', '\xB5', '\a', 
		'K', '\x2', '\x2', '\xB5', '\x121', '\a', 'X', '\x2', '\x2', '\xB6', '\xB7', 
		'\a', '\x46', '\x2', '\x2', '\xB7', '\xB8', '\a', 'K', '\x2', '\x2', '\xB8', 
		'\xB9', '\a', 'X', '\x2', '\x2', '\xB9', '\x121', '\a', 'H', '\x2', '\x2', 
		'\xBA', '\x121', '\a', 'L', '\x2', '\x2', '\xBB', '\xBC', '\a', 'L', '\x2', 
		'\x2', '\xBC', '\xBD', '\a', 'G', '\x2', '\x2', '\xBD', '\x121', '\a', 
		'S', '\x2', '\x2', '\xBE', '\xBF', '\a', 'L', '\x2', '\x2', '\xBF', '\xC0', 
		'\a', 'I', '\x2', '\x2', '\xC0', '\x121', '\a', 'V', '\x2', '\x2', '\xC1', 
		'\xC2', '\a', 'L', '\x2', '\x2', '\xC2', '\xC3', '\a', 'N', '\x2', '\x2', 
		'\xC3', '\x121', '\a', 'V', '\x2', '\x2', '\xC4', '\xC5', '\a', 'L', '\x2', 
		'\x2', '\xC5', '\xC6', '\a', 'U', '\x2', '\x2', '\xC6', '\xC7', '\a', 
		'W', '\x2', '\x2', '\xC7', '\x121', '\a', '\x44', '\x2', '\x2', '\xC8', 
		'\xC9', '\a', 'N', '\x2', '\x2', '\xC9', '\xCA', '\a', '\x46', '\x2', 
		'\x2', '\xCA', '\x121', '\a', '\x43', '\x2', '\x2', '\xCB', '\xCC', '\a', 
		'N', '\x2', '\x2', '\xCC', '\xCD', '\a', '\x46', '\x2', '\x2', '\xCD', 
		'\x121', '\a', '\x44', '\x2', '\x2', '\xCE', '\xCF', '\a', 'N', '\x2', 
		'\x2', '\xCF', '\xD0', '\a', '\x46', '\x2', '\x2', '\xD0', '\xD1', '\a', 
		'\x45', '\x2', '\x2', '\xD1', '\x121', '\a', 'J', '\x2', '\x2', '\xD2', 
		'\xD3', '\a', 'N', '\x2', '\x2', '\xD3', '\xD4', '\a', '\x46', '\x2', 
		'\x2', '\xD4', '\x121', '\a', 'H', '\x2', '\x2', '\xD5', '\xD6', '\a', 
		'N', '\x2', '\x2', '\xD6', '\xD7', '\a', '\x46', '\x2', '\x2', '\xD7', 
		'\x121', '\a', 'N', '\x2', '\x2', '\xD8', '\xD9', '\a', 'N', '\x2', '\x2', 
		'\xD9', '\xDA', '\a', '\x46', '\x2', '\x2', '\xDA', '\x121', '\a', 'U', 
		'\x2', '\x2', '\xDB', '\xDC', '\a', 'N', '\x2', '\x2', '\xDC', '\xDD', 
		'\a', '\x46', '\x2', '\x2', '\xDD', '\x121', '\a', 'V', '\x2', '\x2', 
		'\xDE', '\xDF', '\a', 'N', '\x2', '\x2', '\xDF', '\xE0', '\a', '\x46', 
		'\x2', '\x2', '\xE0', '\x121', '\a', 'Z', '\x2', '\x2', '\xE1', '\xE2', 
		'\a', 'N', '\x2', '\x2', '\xE2', '\xE3', '\a', 'R', '\x2', '\x2', '\xE3', 
		'\x121', '\a', 'U', '\x2', '\x2', '\xE4', '\xE5', '\a', 'O', '\x2', '\x2', 
		'\xE5', '\xE6', '\a', 'W', '\x2', '\x2', '\xE6', '\x121', '\a', 'N', '\x2', 
		'\x2', '\xE7', '\xE8', '\a', 'O', '\x2', '\x2', '\xE8', '\xE9', '\a', 
		'W', '\x2', '\x2', '\xE9', '\xEA', '\a', 'N', '\x2', '\x2', '\xEA', '\x121', 
		'\a', 'H', '\x2', '\x2', '\xEB', '\xEC', '\a', 'Q', '\x2', '\x2', '\xEC', 
		'\x121', '\a', 'T', '\x2', '\x2', '\xED', '\xEE', '\a', 'T', '\x2', '\x2', 
		'\xEE', '\x121', '\a', '\x46', '\x2', '\x2', '\xEF', '\xF0', '\a', 'U', 
		'\x2', '\x2', '\xF0', '\xF1', '\a', 'U', '\x2', '\x2', '\xF1', '\x121', 
		'\a', 'M', '\x2', '\x2', '\xF2', '\xF3', '\a', 'U', '\x2', '\x2', '\xF3', 
		'\xF4', '\a', 'V', '\x2', '\x2', '\xF4', '\x121', '\a', '\x43', '\x2', 
		'\x2', '\xF5', '\xF6', '\a', 'U', '\x2', '\x2', '\xF6', '\xF7', '\a', 
		'V', '\x2', '\x2', '\xF7', '\x121', '\a', '\x44', '\x2', '\x2', '\xF8', 
		'\xF9', '\a', 'U', '\x2', '\x2', '\xF9', '\xFA', '\a', 'V', '\x2', '\x2', 
		'\xFA', '\xFB', '\a', '\x45', '\x2', '\x2', '\xFB', '\x121', '\a', 'J', 
		'\x2', '\x2', '\xFC', '\xFD', '\a', 'U', '\x2', '\x2', '\xFD', '\xFE', 
		'\a', 'V', '\x2', '\x2', '\xFE', '\x121', '\a', 'H', '\x2', '\x2', '\xFF', 
		'\x100', '\a', 'U', '\x2', '\x2', '\x100', '\x101', '\a', 'V', '\x2', 
		'\x2', '\x101', '\x121', '\a', 'K', '\x2', '\x2', '\x102', '\x103', '\a', 
		'U', '\x2', '\x2', '\x103', '\x104', '\a', 'V', '\x2', '\x2', '\x104', 
		'\x121', '\a', 'N', '\x2', '\x2', '\x105', '\x106', '\a', 'U', '\x2', 
		'\x2', '\x106', '\x107', '\a', 'V', '\x2', '\x2', '\x107', '\x121', '\a', 
		'U', '\x2', '\x2', '\x108', '\x109', '\a', 'U', '\x2', '\x2', '\x109', 
		'\x10A', '\a', 'V', '\x2', '\x2', '\x10A', '\x10B', '\a', 'U', '\x2', 
		'\x2', '\x10B', '\x121', '\a', 'Y', '\x2', '\x2', '\x10C', '\x10D', '\a', 
		'U', '\x2', '\x2', '\x10D', '\x10E', '\a', 'V', '\x2', '\x2', '\x10E', 
		'\x121', '\a', 'V', '\x2', '\x2', '\x10F', '\x110', '\a', 'U', '\x2', 
		'\x2', '\x110', '\x111', '\a', 'V', '\x2', '\x2', '\x111', '\x121', '\a', 
		'Z', '\x2', '\x2', '\x112', '\x113', '\a', 'U', '\x2', '\x2', '\x113', 
		'\x114', '\a', 'W', '\x2', '\x2', '\x114', '\x121', '\a', '\x44', '\x2', 
		'\x2', '\x115', '\x116', '\a', 'U', '\x2', '\x2', '\x116', '\x117', '\a', 
		'W', '\x2', '\x2', '\x117', '\x118', '\a', '\x44', '\x2', '\x2', '\x118', 
		'\x121', '\a', 'H', '\x2', '\x2', '\x119', '\x11A', '\a', 'V', '\x2', 
		'\x2', '\x11A', '\x121', '\a', '\x46', '\x2', '\x2', '\x11B', '\x11C', 
		'\a', 'V', '\x2', '\x2', '\x11C', '\x11D', '\a', 'K', '\x2', '\x2', '\x11D', 
		'\x121', '\a', 'Z', '\x2', '\x2', '\x11E', '\x11F', '\a', 'Y', '\x2', 
		'\x2', '\x11F', '\x121', '\a', '\x46', '\x2', '\x2', '\x120', '\xA0', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\xA3', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\xA7', '\x3', '\x2', '\x2', '\x2', '\x120', '\xAA', '\x3', '\x2', 
		'\x2', '\x2', '\x120', '\xAE', '\x3', '\x2', '\x2', '\x2', '\x120', '\xB3', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\xB6', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\xBA', '\x3', '\x2', '\x2', '\x2', '\x120', '\xBB', '\x3', '\x2', 
		'\x2', '\x2', '\x120', '\xBE', '\x3', '\x2', '\x2', '\x2', '\x120', '\xC1', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\xC4', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\xC8', '\x3', '\x2', '\x2', '\x2', '\x120', '\xCB', '\x3', '\x2', 
		'\x2', '\x2', '\x120', '\xCE', '\x3', '\x2', '\x2', '\x2', '\x120', '\xD2', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\xD5', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\xD8', '\x3', '\x2', '\x2', '\x2', '\x120', '\xDB', '\x3', '\x2', 
		'\x2', '\x2', '\x120', '\xDE', '\x3', '\x2', '\x2', '\x2', '\x120', '\xE1', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\xE4', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\xE7', '\x3', '\x2', '\x2', '\x2', '\x120', '\xEB', '\x3', '\x2', 
		'\x2', '\x2', '\x120', '\xED', '\x3', '\x2', '\x2', '\x2', '\x120', '\xEF', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\xF2', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\xF5', '\x3', '\x2', '\x2', '\x2', '\x120', '\xF8', '\x3', '\x2', 
		'\x2', '\x2', '\x120', '\xFC', '\x3', '\x2', '\x2', '\x2', '\x120', '\xFF', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\x102', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\x105', '\x3', '\x2', '\x2', '\x2', '\x120', '\x108', '\x3', 
		'\x2', '\x2', '\x2', '\x120', '\x10C', '\x3', '\x2', '\x2', '\x2', '\x120', 
		'\x10F', '\x3', '\x2', '\x2', '\x2', '\x120', '\x112', '\x3', '\x2', '\x2', 
		'\x2', '\x120', '\x115', '\x3', '\x2', '\x2', '\x2', '\x120', '\x119', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\x11B', '\x3', '\x2', '\x2', '\x2', 
		'\x120', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x121', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\x122', '\x123', '\a', 'Y', '\x2', '\x2', '\x123', 
		'\x124', '\a', 'Q', '\x2', '\x2', '\x124', '\x125', '\a', 'T', '\x2', 
		'\x2', '\x125', '\x12F', '\a', '\x46', '\x2', '\x2', '\x126', '\x127', 
		'\a', 'T', '\x2', '\x2', '\x127', '\x128', '\a', 'G', '\x2', '\x2', '\x128', 
		'\x129', '\a', 'U', '\x2', '\x2', '\x129', '\x12F', '\a', '\x44', '\x2', 
		'\x2', '\x12A', '\x12B', '\a', 'T', '\x2', '\x2', '\x12B', '\x12C', '\a', 
		'G', '\x2', '\x2', '\x12C', '\x12D', '\a', 'U', '\x2', '\x2', '\x12D', 
		'\x12F', '\a', 'Y', '\x2', '\x2', '\x12E', '\x122', '\x3', '\x2', '\x2', 
		'\x2', '\x12E', '\x126', '\x3', '\x2', '\x2', '\x2', '\x12E', '\x12A', 
		'\x3', '\x2', '\x2', '\x2', '\x12F', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\x130', '\x131', '\a', '\x45', '\x2', '\x2', '\x131', '\x132', '\a', 
		')', '\x2', '\x2', '\x132', '\x133', '\x3', '\x2', '\x2', '\x2', '\x133', 
		'\x134', '\x5', '+', '\x16', '\x2', '\x134', '\x135', '\a', ')', '\x2', 
		'\x2', '\x135', '\x13D', '\x3', '\x2', '\x2', '\x2', '\x136', '\x137', 
		'\a', 'Z', '\x2', '\x2', '\x137', '\x138', '\a', ')', '\x2', '\x2', '\x138', 
		'\x139', '\x3', '\x2', '\x2', '\x2', '\x139', '\x13A', '\x5', '\'', '\x14', 
		'\x2', '\x13A', '\x13B', '\a', ')', '\x2', '\x2', '\x13B', '\x13D', '\x3', 
		'\x2', '\x2', '\x2', '\x13C', '\x130', '\x3', '\x2', '\x2', '\x2', '\x13C', 
		'\x136', '\x3', '\x2', '\x2', '\x2', '\x13D', '\"', '\x3', '\x2', '\x2', 
		'\x2', '\x13E', '\x140', '\t', '\x3', '\x2', '\x2', '\x13F', '\x13E', 
		'\x3', '\x2', '\x2', '\x2', '\x140', '\x141', '\x3', '\x2', '\x2', '\x2', 
		'\x141', '\x13F', '\x3', '\x2', '\x2', '\x2', '\x141', '\x142', '\x3', 
		'\x2', '\x2', '\x2', '\x142', '\x144', '\x3', '\x2', '\x2', '\x2', '\x143', 
		'\x145', '\t', '\x4', '\x2', '\x2', '\x144', '\x143', '\x3', '\x2', '\x2', 
		'\x2', '\x144', '\x145', '\x3', '\x2', '\x2', '\x2', '\x145', '$', '\x3', 
		'\x2', '\x2', '\x2', '\x146', '\x147', '\a', '\f', '\x2', '\x2', '\x147', 
		'&', '\x3', '\x2', '\x2', '\x2', '\x148', '\x14A', '\t', '\x3', '\x2', 
		'\x2', '\x149', '\x148', '\x3', '\x2', '\x2', '\x2', '\x14A', '\x14B', 
		'\x3', '\x2', '\x2', '\x2', '\x14B', '\x149', '\x3', '\x2', '\x2', '\x2', 
		'\x14B', '\x14C', '\x3', '\x2', '\x2', '\x2', '\x14C', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x14D', '\x14E', '\x5', '\'', '\x14', '\x2', '\x14E', '\x14F', 
		'\t', '\x4', '\x2', '\x2', '\x14F', '*', '\x3', '\x2', '\x2', '\x2', '\x150', 
		'\x152', '\t', '\x5', '\x2', '\x2', '\x151', '\x150', '\x3', '\x2', '\x2', 
		'\x2', '\x152', '\x153', '\x3', '\x2', '\x2', '\x2', '\x153', '\x151', 
		'\x3', '\x2', '\x2', '\x2', '\x153', '\x154', '\x3', '\x2', '\x2', '\x2', 
		'\x154', ',', '\x3', '\x2', '\x2', '\x2', '\x155', '\x159', '\a', '.', 
		'\x2', '\x2', '\x156', '\x158', '\a', '\"', '\x2', '\x2', '\x157', '\x156', 
		'\x3', '\x2', '\x2', '\x2', '\x158', '\x15B', '\x3', '\x2', '\x2', '\x2', 
		'\x159', '\x157', '\x3', '\x2', '\x2', '\x2', '\x159', '\x15A', '\x3', 
		'\x2', '\x2', '\x2', '\x15A', '\x15C', '\x3', '\x2', '\x2', '\x2', '\x15B', 
		'\x159', '\x3', '\x2', '\x2', '\x2', '\x15C', '\x15D', '\a', 'Z', '\x2', 
		'\x2', '\x15D', '.', '\x3', '\x2', '\x2', '\x2', '\x15E', '\x160', '\t', 
		'\x6', '\x2', '\x2', '\x15F', '\x15E', '\x3', '\x2', '\x2', '\x2', '\x160', 
		'\x161', '\x3', '\x2', '\x2', '\x2', '\x161', '\x15F', '\x3', '\x2', '\x2', 
		'\x2', '\x161', '\x162', '\x3', '\x2', '\x2', '\x2', '\x162', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x163', '\x164', '\t', '\a', '\x2', '\x2', 
		'\x164', '\x32', '\x3', '\x2', '\x2', '\x2', '\x12', '\x2', 'k', 'y', 
		'\x84', '\x9E', '\x120', '\x12E', '\x13C', '\x13F', '\x141', '\x144', 
		'\x149', '\x14B', '\x153', '\x159', '\x161', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
