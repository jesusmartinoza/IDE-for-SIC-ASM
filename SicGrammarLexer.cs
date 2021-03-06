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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, RSUB=8, INSTRUNO=9, 
		INSFDOSRN=10, INSFDOSR=11, INSFDOSRR=12, INSTRES=13, TIPODIRECTIVA=14, 
		BYTEOP=15, REG=16, SEP=17, NUM=18, FINL=19, NUMH=20, NUMHH=21, ID=22, 
		INDEX=23, MODIR=24;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "RSUB", "INSTRUNO", 
		"INSFDOSRN", "INSFDOSR", "INSFDOSRR", "INSTRES", "TIPODIRECTIVA", "BYTEOP", 
		"REG", "SEP", "NUM", "FINL", "NUMH", "NUMHH", "ID", "INDEX", "MODIR"
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
		null, null, null, null, null, null, null, null, null, null, "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "RSUB", "INSTRUNO", "INSFDOSRN", 
		"INSFDOSR", "INSFDOSRR", "INSTRES", "TIPODIRECTIVA", "BYTEOP", "REG", 
		"SEP", "NUM", "FINL", "NUMH", "NUMHH", "ID", "INDEX", "MODIR"
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
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', 'j', 
		'\n', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x5', '\v', 'x', '\n', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x5', '\f', '\x83', '\n', '\f', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x5', '\r', '\x9D', '\n', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x5', '\xE', '\x11F', '\n', '\xE', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x5', '\xF', '\x12D', '\n', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x5', '\x10', '\x13B', '\n', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x12', '\x6', '\x12', '\x140', '\n', '\x12', '\r', '\x12', '\xE', '\x12', 
		'\x141', '\x3', '\x13', '\x6', '\x13', '\x145', '\n', '\x13', '\r', '\x13', 
		'\xE', '\x13', '\x146', '\x3', '\x13', '\x5', '\x13', '\x14A', '\n', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x6', '\x15', '\x14F', '\n', 
		'\x15', '\r', '\x15', '\xE', '\x15', '\x150', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x17', '\x6', '\x17', '\x157', '\n', '\x17', '\r', 
		'\x17', '\xE', '\x17', '\x158', '\x3', '\x18', '\x3', '\x18', '\a', '\x18', 
		'\x15D', '\n', '\x18', '\f', '\x18', '\xE', '\x18', '\x160', '\v', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x2', '\x2', 
		'\x1A', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x31', '\x1A', '\x3', '\x2', '\b', '\a', '\x2', 
		'\x43', '\x44', 'H', 'H', 'N', 'N', 'U', 'V', 'Z', 'Z', '\x4', '\x2', 
		'\v', '\v', '\"', '\"', '\x4', '\x2', '\x32', ';', '\x43', 'H', '\x4', 
		'\x2', 'J', 'J', 'j', 'j', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x4', 
		'\x2', '%', '%', '\x42', '\x42', '\x2', '\x1A1', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\x39', '\x3', '\x2', '\x2', '\x2', '\a', '=', '\x3', '\x2', '\x2', 
		'\x2', '\t', '?', '\x3', '\x2', '\x2', '\x2', '\v', '\x44', '\x3', '\x2', 
		'\x2', '\x2', '\r', 'I', '\x3', '\x2', '\x2', '\x2', '\xF', 'K', '\x3', 
		'\x2', '\x2', '\x2', '\x11', 'O', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'i', '\x3', '\x2', '\x2', '\x2', '\x15', 'w', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '\x82', '\x3', '\x2', '\x2', '\x2', '\x19', '\x9C', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', '\x11E', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x12C', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', '\x13A', '\x3', '\x2', '\x2', '\x2', 
		'!', '\x13C', '\x3', '\x2', '\x2', '\x2', '#', '\x13F', '\x3', '\x2', 
		'\x2', '\x2', '%', '\x144', '\x3', '\x2', '\x2', '\x2', '\'', '\x14B', 
		'\x3', '\x2', '\x2', '\x2', ')', '\x14E', '\x3', '\x2', '\x2', '\x2', 
		'+', '\x152', '\x3', '\x2', '\x2', '\x2', '-', '\x156', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x15A', '\x3', '\x2', '\x2', '\x2', '\x31', '\x163', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\a', 'U', '\x2', '\x2', '\x34', 
		'\x35', '\a', 'V', '\x2', '\x2', '\x35', '\x36', '\a', '\x43', '\x2', 
		'\x2', '\x36', '\x37', '\a', 'T', '\x2', '\x2', '\x37', '\x38', '\a', 
		'V', '\x2', '\x2', '\x38', '\x4', '\x3', '\x2', '\x2', '\x2', '\x39', 
		':', '\a', 'G', '\x2', '\x2', ':', ';', '\a', 'P', '\x2', '\x2', ';', 
		'<', '\a', '\x46', '\x2', '\x2', '<', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\a', '-', '\x2', '\x2', '>', '\b', '\x3', '\x2', '\x2', '\x2', 
		'?', '@', '\a', '\x44', '\x2', '\x2', '@', '\x41', '\a', '[', '\x2', '\x2', 
		'\x41', '\x42', '\a', 'V', '\x2', '\x2', '\x42', '\x43', '\a', 'G', '\x2', 
		'\x2', '\x43', '\n', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\a', 
		'\x44', '\x2', '\x2', '\x45', '\x46', '\a', '\x43', '\x2', '\x2', '\x46', 
		'G', '\a', 'U', '\x2', '\x2', 'G', 'H', '\a', 'G', '\x2', '\x2', 'H', 
		'\f', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', '.', '\x2', '\x2', 'J', 
		'\xE', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', 'U', '\x2', '\x2', 
		'L', 'M', '\a', 'X', '\x2', '\x2', 'M', 'N', '\a', '\x45', '\x2', '\x2', 
		'N', '\x10', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', 'T', '\x2', '\x2', 
		'P', 'Q', '\a', 'U', '\x2', '\x2', 'Q', 'R', '\a', 'W', '\x2', '\x2', 
		'R', 'S', '\a', '\x44', '\x2', '\x2', 'S', '\x12', '\x3', '\x2', '\x2', 
		'\x2', 'T', 'U', '\a', 'H', '\x2', '\x2', 'U', 'V', '\a', 'K', '\x2', 
		'\x2', 'V', 'j', '\a', 'Z', '\x2', '\x2', 'W', 'X', '\a', 'H', '\x2', 
		'\x2', 'X', 'Y', '\a', 'N', '\x2', '\x2', 'Y', 'Z', '\a', 'Q', '\x2', 
		'\x2', 'Z', '[', '\a', '\x43', '\x2', '\x2', '[', 'j', '\a', 'V', '\x2', 
		'\x2', '\\', ']', '\a', 'J', '\x2', '\x2', ']', '^', '\a', 'K', '\x2', 
		'\x2', '^', 'j', '\a', 'Q', '\x2', '\x2', '_', '`', '\a', 'P', '\x2', 
		'\x2', '`', '\x61', '\a', 'Q', '\x2', '\x2', '\x61', '\x62', '\a', 'T', 
		'\x2', '\x2', '\x62', 'j', '\a', 'O', '\x2', '\x2', '\x63', '\x64', '\a', 
		'U', '\x2', '\x2', '\x64', '\x65', '\a', 'K', '\x2', '\x2', '\x65', 'j', 
		'\a', 'Q', '\x2', '\x2', '\x66', 'g', '\a', 'V', '\x2', '\x2', 'g', 'h', 
		'\a', 'K', '\x2', '\x2', 'h', 'j', '\a', 'Q', '\x2', '\x2', 'i', 'T', 
		'\x3', '\x2', '\x2', '\x2', 'i', 'W', '\x3', '\x2', '\x2', '\x2', 'i', 
		'\\', '\x3', '\x2', '\x2', '\x2', 'i', '_', '\x3', '\x2', '\x2', '\x2', 
		'i', '\x63', '\x3', '\x2', '\x2', '\x2', 'i', '\x66', '\x3', '\x2', '\x2', 
		'\x2', 'j', '\x14', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\a', 'U', '\x2', 
		'\x2', 'l', 'm', '\a', 'J', '\x2', '\x2', 'm', 'n', '\a', 'K', '\x2', 
		'\x2', 'n', 'o', '\a', 'H', '\x2', '\x2', 'o', 'p', '\a', 'V', '\x2', 
		'\x2', 'p', 'x', '\a', 'T', '\x2', '\x2', 'q', 'r', '\a', 'U', '\x2', 
		'\x2', 'r', 's', '\a', 'J', '\x2', '\x2', 's', 't', '\a', 'K', '\x2', 
		'\x2', 't', 'u', '\a', 'H', '\x2', '\x2', 'u', 'v', '\a', 'V', '\x2', 
		'\x2', 'v', 'x', '\a', 'N', '\x2', '\x2', 'w', 'k', '\x3', '\x2', '\x2', 
		'\x2', 'w', 'q', '\x3', '\x2', '\x2', '\x2', 'x', '\x16', '\x3', '\x2', 
		'\x2', '\x2', 'y', 'z', '\a', '\x45', '\x2', '\x2', 'z', '{', '\a', 'N', 
		'\x2', '\x2', '{', '|', '\a', 'G', '\x2', '\x2', '|', '}', '\a', '\x43', 
		'\x2', '\x2', '}', '\x83', '\a', 'T', '\x2', '\x2', '~', '\x7F', '\a', 
		'V', '\x2', '\x2', '\x7F', '\x80', '\a', 'K', '\x2', '\x2', '\x80', '\x81', 
		'\a', 'Z', '\x2', '\x2', '\x81', '\x83', '\a', 'T', '\x2', '\x2', '\x82', 
		'y', '\x3', '\x2', '\x2', '\x2', '\x82', '~', '\x3', '\x2', '\x2', '\x2', 
		'\x83', '\x18', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', '\x43', 
		'\x2', '\x2', '\x85', '\x86', '\a', '\x46', '\x2', '\x2', '\x86', '\x87', 
		'\a', '\x46', '\x2', '\x2', '\x87', '\x9D', '\a', 'T', '\x2', '\x2', '\x88', 
		'\x89', '\a', '\x45', '\x2', '\x2', '\x89', '\x8A', '\a', 'Q', '\x2', 
		'\x2', '\x8A', '\x8B', '\a', 'O', '\x2', '\x2', '\x8B', '\x8C', '\a', 
		'R', '\x2', '\x2', '\x8C', '\x9D', '\a', 'T', '\x2', '\x2', '\x8D', '\x8E', 
		'\a', '\x46', '\x2', '\x2', '\x8E', '\x8F', '\a', 'K', '\x2', '\x2', '\x8F', 
		'\x90', '\a', 'X', '\x2', '\x2', '\x90', '\x9D', '\a', 'T', '\x2', '\x2', 
		'\x91', '\x92', '\a', 'O', '\x2', '\x2', '\x92', '\x93', '\a', 'W', '\x2', 
		'\x2', '\x93', '\x94', '\a', 'N', '\x2', '\x2', '\x94', '\x9D', '\a', 
		'T', '\x2', '\x2', '\x95', '\x96', '\a', 'T', '\x2', '\x2', '\x96', '\x97', 
		'\a', 'O', '\x2', '\x2', '\x97', '\x9D', '\a', 'Q', '\x2', '\x2', '\x98', 
		'\x99', '\a', 'U', '\x2', '\x2', '\x99', '\x9A', '\a', 'W', '\x2', '\x2', 
		'\x9A', '\x9B', '\a', '\x44', '\x2', '\x2', '\x9B', '\x9D', '\a', 'T', 
		'\x2', '\x2', '\x9C', '\x84', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x88', 
		'\x3', '\x2', '\x2', '\x2', '\x9C', '\x8D', '\x3', '\x2', '\x2', '\x2', 
		'\x9C', '\x91', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x95', '\x3', '\x2', 
		'\x2', '\x2', '\x9C', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\x9E', '\x9F', '\a', '\x43', '\x2', '\x2', 
		'\x9F', '\xA0', '\a', '\x46', '\x2', '\x2', '\xA0', '\x11F', '\a', '\x46', 
		'\x2', '\x2', '\xA1', '\xA2', '\a', '\x43', '\x2', '\x2', '\xA2', '\xA3', 
		'\a', '\x46', '\x2', '\x2', '\xA3', '\xA4', '\a', '\x46', '\x2', '\x2', 
		'\xA4', '\x11F', '\a', 'H', '\x2', '\x2', '\xA5', '\xA6', '\a', '\x43', 
		'\x2', '\x2', '\xA6', '\xA7', '\a', 'P', '\x2', '\x2', '\xA7', '\x11F', 
		'\a', '\x46', '\x2', '\x2', '\xA8', '\xA9', '\a', '\x45', '\x2', '\x2', 
		'\xA9', '\xAA', '\a', 'Q', '\x2', '\x2', '\xAA', '\xAB', '\a', 'O', '\x2', 
		'\x2', '\xAB', '\x11F', '\a', 'R', '\x2', '\x2', '\xAC', '\xAD', '\a', 
		'\x45', '\x2', '\x2', '\xAD', '\xAE', '\a', 'Q', '\x2', '\x2', '\xAE', 
		'\xAF', '\a', 'O', '\x2', '\x2', '\xAF', '\xB0', '\a', 'R', '\x2', '\x2', 
		'\xB0', '\x11F', '\a', 'H', '\x2', '\x2', '\xB1', '\xB2', '\a', '\x46', 
		'\x2', '\x2', '\xB2', '\xB3', '\a', 'K', '\x2', '\x2', '\xB3', '\x11F', 
		'\a', 'X', '\x2', '\x2', '\xB4', '\xB5', '\a', '\x46', '\x2', '\x2', '\xB5', 
		'\xB6', '\a', 'K', '\x2', '\x2', '\xB6', '\xB7', '\a', 'X', '\x2', '\x2', 
		'\xB7', '\x11F', '\a', 'H', '\x2', '\x2', '\xB8', '\x11F', '\a', 'L', 
		'\x2', '\x2', '\xB9', '\xBA', '\a', 'L', '\x2', '\x2', '\xBA', '\xBB', 
		'\a', 'G', '\x2', '\x2', '\xBB', '\x11F', '\a', 'S', '\x2', '\x2', '\xBC', 
		'\xBD', '\a', 'L', '\x2', '\x2', '\xBD', '\xBE', '\a', 'I', '\x2', '\x2', 
		'\xBE', '\x11F', '\a', 'V', '\x2', '\x2', '\xBF', '\xC0', '\a', 'L', '\x2', 
		'\x2', '\xC0', '\xC1', '\a', 'N', '\x2', '\x2', '\xC1', '\x11F', '\a', 
		'V', '\x2', '\x2', '\xC2', '\xC3', '\a', 'L', '\x2', '\x2', '\xC3', '\xC4', 
		'\a', 'U', '\x2', '\x2', '\xC4', '\xC5', '\a', 'W', '\x2', '\x2', '\xC5', 
		'\x11F', '\a', '\x44', '\x2', '\x2', '\xC6', '\xC7', '\a', 'N', '\x2', 
		'\x2', '\xC7', '\xC8', '\a', '\x46', '\x2', '\x2', '\xC8', '\x11F', '\a', 
		'\x43', '\x2', '\x2', '\xC9', '\xCA', '\a', 'N', '\x2', '\x2', '\xCA', 
		'\xCB', '\a', '\x46', '\x2', '\x2', '\xCB', '\x11F', '\a', '\x44', '\x2', 
		'\x2', '\xCC', '\xCD', '\a', 'N', '\x2', '\x2', '\xCD', '\xCE', '\a', 
		'\x46', '\x2', '\x2', '\xCE', '\xCF', '\a', '\x45', '\x2', '\x2', '\xCF', 
		'\x11F', '\a', 'J', '\x2', '\x2', '\xD0', '\xD1', '\a', 'N', '\x2', '\x2', 
		'\xD1', '\xD2', '\a', '\x46', '\x2', '\x2', '\xD2', '\x11F', '\a', 'H', 
		'\x2', '\x2', '\xD3', '\xD4', '\a', 'N', '\x2', '\x2', '\xD4', '\xD5', 
		'\a', '\x46', '\x2', '\x2', '\xD5', '\x11F', '\a', 'N', '\x2', '\x2', 
		'\xD6', '\xD7', '\a', 'N', '\x2', '\x2', '\xD7', '\xD8', '\a', '\x46', 
		'\x2', '\x2', '\xD8', '\x11F', '\a', 'U', '\x2', '\x2', '\xD9', '\xDA', 
		'\a', 'N', '\x2', '\x2', '\xDA', '\xDB', '\a', '\x46', '\x2', '\x2', '\xDB', 
		'\x11F', '\a', 'V', '\x2', '\x2', '\xDC', '\xDD', '\a', 'N', '\x2', '\x2', 
		'\xDD', '\xDE', '\a', '\x46', '\x2', '\x2', '\xDE', '\x11F', '\a', 'Z', 
		'\x2', '\x2', '\xDF', '\xE0', '\a', 'N', '\x2', '\x2', '\xE0', '\xE1', 
		'\a', 'R', '\x2', '\x2', '\xE1', '\x11F', '\a', 'U', '\x2', '\x2', '\xE2', 
		'\xE3', '\a', 'O', '\x2', '\x2', '\xE3', '\xE4', '\a', 'W', '\x2', '\x2', 
		'\xE4', '\x11F', '\a', 'N', '\x2', '\x2', '\xE5', '\xE6', '\a', 'O', '\x2', 
		'\x2', '\xE6', '\xE7', '\a', 'W', '\x2', '\x2', '\xE7', '\xE8', '\a', 
		'N', '\x2', '\x2', '\xE8', '\x11F', '\a', 'H', '\x2', '\x2', '\xE9', '\xEA', 
		'\a', 'Q', '\x2', '\x2', '\xEA', '\x11F', '\a', 'T', '\x2', '\x2', '\xEB', 
		'\xEC', '\a', 'T', '\x2', '\x2', '\xEC', '\x11F', '\a', '\x46', '\x2', 
		'\x2', '\xED', '\xEE', '\a', 'U', '\x2', '\x2', '\xEE', '\xEF', '\a', 
		'U', '\x2', '\x2', '\xEF', '\x11F', '\a', 'M', '\x2', '\x2', '\xF0', '\xF1', 
		'\a', 'U', '\x2', '\x2', '\xF1', '\xF2', '\a', 'V', '\x2', '\x2', '\xF2', 
		'\x11F', '\a', '\x43', '\x2', '\x2', '\xF3', '\xF4', '\a', 'U', '\x2', 
		'\x2', '\xF4', '\xF5', '\a', 'V', '\x2', '\x2', '\xF5', '\x11F', '\a', 
		'\x44', '\x2', '\x2', '\xF6', '\xF7', '\a', 'U', '\x2', '\x2', '\xF7', 
		'\xF8', '\a', 'V', '\x2', '\x2', '\xF8', '\xF9', '\a', '\x45', '\x2', 
		'\x2', '\xF9', '\x11F', '\a', 'J', '\x2', '\x2', '\xFA', '\xFB', '\a', 
		'U', '\x2', '\x2', '\xFB', '\xFC', '\a', 'V', '\x2', '\x2', '\xFC', '\x11F', 
		'\a', 'H', '\x2', '\x2', '\xFD', '\xFE', '\a', 'U', '\x2', '\x2', '\xFE', 
		'\xFF', '\a', 'V', '\x2', '\x2', '\xFF', '\x11F', '\a', 'K', '\x2', '\x2', 
		'\x100', '\x101', '\a', 'U', '\x2', '\x2', '\x101', '\x102', '\a', 'V', 
		'\x2', '\x2', '\x102', '\x11F', '\a', 'N', '\x2', '\x2', '\x103', '\x104', 
		'\a', 'U', '\x2', '\x2', '\x104', '\x105', '\a', 'V', '\x2', '\x2', '\x105', 
		'\x11F', '\a', 'U', '\x2', '\x2', '\x106', '\x107', '\a', 'U', '\x2', 
		'\x2', '\x107', '\x108', '\a', 'V', '\x2', '\x2', '\x108', '\x109', '\a', 
		'U', '\x2', '\x2', '\x109', '\x11F', '\a', 'Y', '\x2', '\x2', '\x10A', 
		'\x10B', '\a', 'U', '\x2', '\x2', '\x10B', '\x10C', '\a', 'V', '\x2', 
		'\x2', '\x10C', '\x11F', '\a', 'V', '\x2', '\x2', '\x10D', '\x10E', '\a', 
		'U', '\x2', '\x2', '\x10E', '\x10F', '\a', 'V', '\x2', '\x2', '\x10F', 
		'\x11F', '\a', 'Z', '\x2', '\x2', '\x110', '\x111', '\a', 'U', '\x2', 
		'\x2', '\x111', '\x112', '\a', 'W', '\x2', '\x2', '\x112', '\x11F', '\a', 
		'\x44', '\x2', '\x2', '\x113', '\x114', '\a', 'U', '\x2', '\x2', '\x114', 
		'\x115', '\a', 'W', '\x2', '\x2', '\x115', '\x116', '\a', '\x44', '\x2', 
		'\x2', '\x116', '\x11F', '\a', 'H', '\x2', '\x2', '\x117', '\x118', '\a', 
		'V', '\x2', '\x2', '\x118', '\x11F', '\a', '\x46', '\x2', '\x2', '\x119', 
		'\x11A', '\a', 'V', '\x2', '\x2', '\x11A', '\x11B', '\a', 'K', '\x2', 
		'\x2', '\x11B', '\x11F', '\a', 'Z', '\x2', '\x2', '\x11C', '\x11D', '\a', 
		'Y', '\x2', '\x2', '\x11D', '\x11F', '\a', '\x46', '\x2', '\x2', '\x11E', 
		'\x9E', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xA1', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\xA5', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xA8', '\x3', 
		'\x2', '\x2', '\x2', '\x11E', '\xAC', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\xB1', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xB4', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\xB8', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xB9', '\x3', 
		'\x2', '\x2', '\x2', '\x11E', '\xBC', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\xBF', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xC2', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\xC6', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xC9', '\x3', 
		'\x2', '\x2', '\x2', '\x11E', '\xCC', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\xD0', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\xD6', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xD9', '\x3', 
		'\x2', '\x2', '\x2', '\x11E', '\xDC', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\xDF', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xE2', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\xE5', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xE9', '\x3', 
		'\x2', '\x2', '\x2', '\x11E', '\xEB', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\xED', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xF0', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\xF3', '\x3', '\x2', '\x2', '\x2', '\x11E', '\xF6', '\x3', 
		'\x2', '\x2', '\x2', '\x11E', '\xFA', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\xFD', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x100', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\x103', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x106', 
		'\x3', '\x2', '\x2', '\x2', '\x11E', '\x10A', '\x3', '\x2', '\x2', '\x2', 
		'\x11E', '\x10D', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x110', '\x3', 
		'\x2', '\x2', '\x2', '\x11E', '\x113', '\x3', '\x2', '\x2', '\x2', '\x11E', 
		'\x117', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x119', '\x3', '\x2', '\x2', 
		'\x2', '\x11E', '\x11C', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', '\x120', '\x121', '\a', 'Y', '\x2', '\x2', 
		'\x121', '\x122', '\a', 'Q', '\x2', '\x2', '\x122', '\x123', '\a', 'T', 
		'\x2', '\x2', '\x123', '\x12D', '\a', '\x46', '\x2', '\x2', '\x124', '\x125', 
		'\a', 'T', '\x2', '\x2', '\x125', '\x126', '\a', 'G', '\x2', '\x2', '\x126', 
		'\x127', '\a', 'U', '\x2', '\x2', '\x127', '\x12D', '\a', '\x44', '\x2', 
		'\x2', '\x128', '\x129', '\a', 'T', '\x2', '\x2', '\x129', '\x12A', '\a', 
		'G', '\x2', '\x2', '\x12A', '\x12B', '\a', 'U', '\x2', '\x2', '\x12B', 
		'\x12D', '\a', 'Y', '\x2', '\x2', '\x12C', '\x120', '\x3', '\x2', '\x2', 
		'\x2', '\x12C', '\x124', '\x3', '\x2', '\x2', '\x2', '\x12C', '\x128', 
		'\x3', '\x2', '\x2', '\x2', '\x12D', '\x1E', '\x3', '\x2', '\x2', '\x2', 
		'\x12E', '\x12F', '\a', '\x45', '\x2', '\x2', '\x12F', '\x130', '\a', 
		')', '\x2', '\x2', '\x130', '\x131', '\x3', '\x2', '\x2', '\x2', '\x131', 
		'\x132', '\x5', '-', '\x17', '\x2', '\x132', '\x133', '\a', ')', '\x2', 
		'\x2', '\x133', '\x13B', '\x3', '\x2', '\x2', '\x2', '\x134', '\x135', 
		'\a', 'Z', '\x2', '\x2', '\x135', '\x136', '\a', ')', '\x2', '\x2', '\x136', 
		'\x137', '\x3', '\x2', '\x2', '\x2', '\x137', '\x138', '\x5', ')', '\x15', 
		'\x2', '\x138', '\x139', '\a', ')', '\x2', '\x2', '\x139', '\x13B', '\x3', 
		'\x2', '\x2', '\x2', '\x13A', '\x12E', '\x3', '\x2', '\x2', '\x2', '\x13A', 
		'\x134', '\x3', '\x2', '\x2', '\x2', '\x13B', ' ', '\x3', '\x2', '\x2', 
		'\x2', '\x13C', '\x13D', '\t', '\x2', '\x2', '\x2', '\x13D', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\x13E', '\x140', '\t', '\x3', '\x2', '\x2', '\x13F', 
		'\x13E', '\x3', '\x2', '\x2', '\x2', '\x140', '\x141', '\x3', '\x2', '\x2', 
		'\x2', '\x141', '\x13F', '\x3', '\x2', '\x2', '\x2', '\x141', '\x142', 
		'\x3', '\x2', '\x2', '\x2', '\x142', '$', '\x3', '\x2', '\x2', '\x2', 
		'\x143', '\x145', '\t', '\x4', '\x2', '\x2', '\x144', '\x143', '\x3', 
		'\x2', '\x2', '\x2', '\x145', '\x146', '\x3', '\x2', '\x2', '\x2', '\x146', 
		'\x144', '\x3', '\x2', '\x2', '\x2', '\x146', '\x147', '\x3', '\x2', '\x2', 
		'\x2', '\x147', '\x149', '\x3', '\x2', '\x2', '\x2', '\x148', '\x14A', 
		'\t', '\x5', '\x2', '\x2', '\x149', '\x148', '\x3', '\x2', '\x2', '\x2', 
		'\x149', '\x14A', '\x3', '\x2', '\x2', '\x2', '\x14A', '&', '\x3', '\x2', 
		'\x2', '\x2', '\x14B', '\x14C', '\a', '\f', '\x2', '\x2', '\x14C', '(', 
		'\x3', '\x2', '\x2', '\x2', '\x14D', '\x14F', '\t', '\x4', '\x2', '\x2', 
		'\x14E', '\x14D', '\x3', '\x2', '\x2', '\x2', '\x14F', '\x150', '\x3', 
		'\x2', '\x2', '\x2', '\x150', '\x14E', '\x3', '\x2', '\x2', '\x2', '\x150', 
		'\x151', '\x3', '\x2', '\x2', '\x2', '\x151', '*', '\x3', '\x2', '\x2', 
		'\x2', '\x152', '\x153', '\x5', ')', '\x15', '\x2', '\x153', '\x154', 
		'\t', '\x5', '\x2', '\x2', '\x154', ',', '\x3', '\x2', '\x2', '\x2', '\x155', 
		'\x157', '\t', '\x6', '\x2', '\x2', '\x156', '\x155', '\x3', '\x2', '\x2', 
		'\x2', '\x157', '\x158', '\x3', '\x2', '\x2', '\x2', '\x158', '\x156', 
		'\x3', '\x2', '\x2', '\x2', '\x158', '\x159', '\x3', '\x2', '\x2', '\x2', 
		'\x159', '.', '\x3', '\x2', '\x2', '\x2', '\x15A', '\x15E', '\a', '.', 
		'\x2', '\x2', '\x15B', '\x15D', '\a', '\"', '\x2', '\x2', '\x15C', '\x15B', 
		'\x3', '\x2', '\x2', '\x2', '\x15D', '\x160', '\x3', '\x2', '\x2', '\x2', 
		'\x15E', '\x15C', '\x3', '\x2', '\x2', '\x2', '\x15E', '\x15F', '\x3', 
		'\x2', '\x2', '\x2', '\x15F', '\x161', '\x3', '\x2', '\x2', '\x2', '\x160', 
		'\x15E', '\x3', '\x2', '\x2', '\x2', '\x161', '\x162', '\a', 'Z', '\x2', 
		'\x2', '\x162', '\x30', '\x3', '\x2', '\x2', '\x2', '\x163', '\x164', 
		'\t', '\a', '\x2', '\x2', '\x164', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\x12', '\x2', 'i', 'w', '\x82', '\x9C', '\x11E', '\x12C', '\x13A', '\x141', 
		'\x144', '\x146', '\x149', '\x14E', '\x150', '\x158', '\x15E', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
