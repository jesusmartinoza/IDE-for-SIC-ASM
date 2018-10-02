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
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class SicGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, RSUB=6, INSTRUCCIONES=7, TIPODIRECTIVA=8, 
		BYTEOP=9, NUM=10, RB=11, STB=12, FINL=13, NUMH=14, NUMHH=15, ID=16, SEP=17;
	public const int
		RULE_programa = 0, RULE_inicio = 1, RULE_fin = 2, RULE_proposicion = 3, 
		RULE_instruccion = 4, RULE_directiva = 5, RULE_opinstruccion = 6;
	public static readonly string[] ruleNames = {
		"programa", "inicio", "fin", "proposicion", "instruccion", "directiva", 
		"opinstruccion"
	};

	private static readonly string[] _LiteralNames = {
		null, "'END'", "'BYTE'", "','", "' '", "'X'", null, null, null, null, 
		null, "'RSUB'", "'START'", "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "RSUB", "INSTRUCCIONES", "TIPODIRECTIVA", 
		"BYTEOP", "NUM", "RB", "STB", "FINL", "NUMH", "NUMHH", "ID", "SEP"
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

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SicGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SicGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SicGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class ProgramaContext : ParserRuleContext {
		public InicioContext inicio() {
			return GetRuleContext<InicioContext>(0);
		}
		public FinContext fin() {
			return GetRuleContext<FinContext>(0);
		}
		public ProposicionContext[] proposicion() {
			return GetRuleContexts<ProposicionContext>();
		}
		public ProposicionContext proposicion(int i) {
			return GetRuleContext<ProposicionContext>(i);
		}
		public ProgramaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_programa; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.EnterPrograma(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.ExitPrograma(this);
		}
	}

	[RuleVersion(0)]
	public ProgramaContext programa() {
		ProgramaContext _localctx = new ProgramaContext(Context, State);
		EnterRule(_localctx, 0, RULE_programa);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; inicio();
			State = 16;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 15; proposicion();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 18;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 20; fin();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InicioContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(SicGrammarParser.ID, 0); }
		public ITerminalNode[] SEP() { return GetTokens(SicGrammarParser.SEP); }
		public ITerminalNode SEP(int i) {
			return GetToken(SicGrammarParser.SEP, i);
		}
		public ITerminalNode STB() { return GetToken(SicGrammarParser.STB, 0); }
		public ITerminalNode NUM() { return GetToken(SicGrammarParser.NUM, 0); }
		public ITerminalNode FINL() { return GetToken(SicGrammarParser.FINL, 0); }
		public InicioContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inicio; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.EnterInicio(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.ExitInicio(this);
		}
	}

	[RuleVersion(0)]
	public InicioContext inicio() {
		InicioContext _localctx = new InicioContext(Context, State);
		EnterRule(_localctx, 2, RULE_inicio);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22; Match(ID);
			State = 23; Match(SEP);
			State = 24; Match(STB);
			State = 25; Match(SEP);
			State = 26; Match(NUM);
			State = 27; Match(FINL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FinContext : ParserRuleContext {
		public ITerminalNode[] SEP() { return GetTokens(SicGrammarParser.SEP); }
		public ITerminalNode SEP(int i) {
			return GetToken(SicGrammarParser.SEP, i);
		}
		public ITerminalNode ID() { return GetToken(SicGrammarParser.ID, 0); }
		public ITerminalNode FINL() { return GetToken(SicGrammarParser.FINL, 0); }
		public FinContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fin; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.EnterFin(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.ExitFin(this);
		}
	}

	[RuleVersion(0)]
	public FinContext fin() {
		FinContext _localctx = new FinContext(Context, State);
		EnterRule(_localctx, 4, RULE_fin);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 29; Match(SEP);
			State = 30; Match(T__0);
			State = 33;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SEP) {
				{
				State = 31; Match(SEP);
				State = 32; Match(ID);
				}
			}

			State = 36;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==FINL) {
				{
				State = 35; Match(FINL);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ProposicionContext : ParserRuleContext {
		public ITerminalNode FINL() { return GetToken(SicGrammarParser.FINL, 0); }
		public InstruccionContext instruccion() {
			return GetRuleContext<InstruccionContext>(0);
		}
		public DirectivaContext directiva() {
			return GetRuleContext<DirectivaContext>(0);
		}
		public ITerminalNode RSUB() { return GetToken(SicGrammarParser.RSUB, 0); }
		public ProposicionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_proposicion; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.EnterProposicion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.ExitProposicion(this);
		}
	}

	[RuleVersion(0)]
	public ProposicionContext proposicion() {
		ProposicionContext _localctx = new ProposicionContext(Context, State);
		EnterRule(_localctx, 6, RULE_proposicion);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				{
				State = 38; instruccion();
				}
				break;
			case 2:
				{
				State = 39; directiva();
				}
				break;
			case 3:
				{
				State = 40; Match(RSUB);
				}
				break;
			}
			State = 43; Match(FINL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstruccionContext : ParserRuleContext {
		public ITerminalNode[] SEP() { return GetTokens(SicGrammarParser.SEP); }
		public ITerminalNode SEP(int i) {
			return GetToken(SicGrammarParser.SEP, i);
		}
		public ITerminalNode INSTRUCCIONES() { return GetToken(SicGrammarParser.INSTRUCCIONES, 0); }
		public OpinstruccionContext opinstruccion() {
			return GetRuleContext<OpinstruccionContext>(0);
		}
		public ITerminalNode ID() { return GetToken(SicGrammarParser.ID, 0); }
		public InstruccionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instruccion; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.EnterInstruccion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.ExitInstruccion(this);
		}
	}

	[RuleVersion(0)]
	public InstruccionContext instruccion() {
		InstruccionContext _localctx = new InstruccionContext(Context, State);
		EnterRule(_localctx, 8, RULE_instruccion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ID) {
				{
				State = 45; Match(ID);
				}
			}

			State = 48; Match(SEP);
			State = 49; Match(INSTRUCCIONES);
			State = 50; Match(SEP);
			State = 51; opinstruccion();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DirectivaContext : ParserRuleContext {
		public ITerminalNode[] SEP() { return GetTokens(SicGrammarParser.SEP); }
		public ITerminalNode SEP(int i) {
			return GetToken(SicGrammarParser.SEP, i);
		}
		public ITerminalNode BYTEOP() { return GetToken(SicGrammarParser.BYTEOP, 0); }
		public ITerminalNode ID() { return GetToken(SicGrammarParser.ID, 0); }
		public ITerminalNode TIPODIRECTIVA() { return GetToken(SicGrammarParser.TIPODIRECTIVA, 0); }
		public ITerminalNode NUM() { return GetToken(SicGrammarParser.NUM, 0); }
		public DirectivaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directiva; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.EnterDirectiva(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.ExitDirectiva(this);
		}
	}

	[RuleVersion(0)]
	public DirectivaContext directiva() {
		DirectivaContext _localctx = new DirectivaContext(Context, State);
		EnterRule(_localctx, 10, RULE_directiva);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ID) {
				{
				State = 53; Match(ID);
				}
			}

			State = 56; Match(SEP);
			State = 63;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__1:
				{
				State = 57; Match(T__1);
				State = 58; Match(SEP);
				State = 59; Match(BYTEOP);
				}
				break;
			case TIPODIRECTIVA:
				{
				{
				State = 60; Match(TIPODIRECTIVA);
				State = 61; Match(SEP);
				State = 62; Match(NUM);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OpinstruccionContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(SicGrammarParser.ID, 0); }
		public OpinstruccionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_opinstruccion; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.EnterOpinstruccion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISicGrammarListener typedListener = listener as ISicGrammarListener;
			if (typedListener != null) typedListener.ExitOpinstruccion(this);
		}
	}

	[RuleVersion(0)]
	public OpinstruccionContext opinstruccion() {
		OpinstruccionContext _localctx = new OpinstruccionContext(Context, State);
		EnterRule(_localctx, 12, RULE_opinstruccion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 65; Match(ID);
			State = 74;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__2) {
				{
				State = 66; Match(T__2);
				State = 70;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==T__3) {
					{
					{
					State = 67; Match(T__3);
					}
					}
					State = 72;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 73; Match(T__4);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x13', 'O', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x3', '\x2', '\x3', '\x2', '\x6', '\x2', '\x13', '\n', '\x2', '\r', '\x2', 
		'\xE', '\x2', '\x14', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', 
		'\x4', '$', '\n', '\x4', '\x3', '\x4', '\x5', '\x4', '\'', '\n', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', ',', '\n', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x5', '\x6', '\x31', '\n', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x5', '\a', '\x39', '\n', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x5', '\a', '\x42', '\n', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\a', '\b', 'G', '\n', '\b', '\f', '\b', '\xE', '\b', 'J', '\v', '\b', 
		'\x3', '\b', '\x5', '\b', 'M', '\n', '\b', '\x3', '\b', '\x2', '\x2', 
		'\t', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x2', '\x2', '\x2', 
		'Q', '\x2', '\x10', '\x3', '\x2', '\x2', '\x2', '\x4', '\x18', '\x3', 
		'\x2', '\x2', '\x2', '\x6', '\x1F', '\x3', '\x2', '\x2', '\x2', '\b', 
		'+', '\x3', '\x2', '\x2', '\x2', '\n', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\f', '\x38', '\x3', '\x2', '\x2', '\x2', '\xE', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x10', '\x12', '\x5', '\x4', '\x3', '\x2', '\x11', '\x13', 
		'\x5', '\b', '\x5', '\x2', '\x12', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '\x14', '\x3', '\x2', '\x2', '\x2', '\x14', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\x14', '\x15', '\x3', '\x2', '\x2', '\x2', '\x15', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\x5', '\x6', '\x4', '\x2', 
		'\x17', '\x3', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', '\a', '\x12', 
		'\x2', '\x2', '\x19', '\x1A', '\a', '\x13', '\x2', '\x2', '\x1A', '\x1B', 
		'\a', '\xE', '\x2', '\x2', '\x1B', '\x1C', '\a', '\x13', '\x2', '\x2', 
		'\x1C', '\x1D', '\a', '\f', '\x2', '\x2', '\x1D', '\x1E', '\a', '\xF', 
		'\x2', '\x2', '\x1E', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', 
		'\a', '\x13', '\x2', '\x2', ' ', '#', '\a', '\x3', '\x2', '\x2', '!', 
		'\"', '\a', '\x13', '\x2', '\x2', '\"', '$', '\a', '\x12', '\x2', '\x2', 
		'#', '!', '\x3', '\x2', '\x2', '\x2', '#', '$', '\x3', '\x2', '\x2', '\x2', 
		'$', '&', '\x3', '\x2', '\x2', '\x2', '%', '\'', '\a', '\xF', '\x2', '\x2', 
		'&', '%', '\x3', '\x2', '\x2', '\x2', '&', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\a', '\x3', '\x2', '\x2', '\x2', '(', ',', '\x5', '\n', 
		'\x6', '\x2', ')', ',', '\x5', '\f', '\a', '\x2', '*', ',', '\a', '\b', 
		'\x2', '\x2', '+', '(', '\x3', '\x2', '\x2', '\x2', '+', ')', '\x3', '\x2', 
		'\x2', '\x2', '+', '*', '\x3', '\x2', '\x2', '\x2', ',', '-', '\x3', '\x2', 
		'\x2', '\x2', '-', '.', '\a', '\xF', '\x2', '\x2', '.', '\t', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x31', '\a', '\x12', '\x2', '\x2', '\x30', '/', '\x3', 
		'\x2', '\x2', '\x2', '\x30', '\x31', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\a', '\x13', '\x2', 
		'\x2', '\x33', '\x34', '\a', '\t', '\x2', '\x2', '\x34', '\x35', '\a', 
		'\x13', '\x2', '\x2', '\x35', '\x36', '\x5', '\xE', '\b', '\x2', '\x36', 
		'\v', '\x3', '\x2', '\x2', '\x2', '\x37', '\x39', '\a', '\x12', '\x2', 
		'\x2', '\x38', '\x37', '\x3', '\x2', '\x2', '\x2', '\x38', '\x39', '\x3', 
		'\x2', '\x2', '\x2', '\x39', ':', '\x3', '\x2', '\x2', '\x2', ':', '\x41', 
		'\a', '\x13', '\x2', '\x2', ';', '<', '\a', '\x4', '\x2', '\x2', '<', 
		'=', '\a', '\x13', '\x2', '\x2', '=', '\x42', '\a', '\v', '\x2', '\x2', 
		'>', '?', '\a', '\n', '\x2', '\x2', '?', '@', '\a', '\x13', '\x2', '\x2', 
		'@', '\x42', '\a', '\f', '\x2', '\x2', '\x41', ';', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '>', '\x3', '\x2', '\x2', '\x2', '\x42', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x43', 'L', '\a', '\x12', '\x2', '\x2', '\x44', 'H', '\a', 
		'\x5', '\x2', '\x2', '\x45', 'G', '\a', '\x6', '\x2', '\x2', '\x46', '\x45', 
		'\x3', '\x2', '\x2', '\x2', 'G', 'J', '\x3', '\x2', '\x2', '\x2', 'H', 
		'\x46', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\x3', '\x2', '\x2', '\x2', 
		'I', 'K', '\x3', '\x2', '\x2', '\x2', 'J', 'H', '\x3', '\x2', '\x2', '\x2', 
		'K', 'M', '\a', '\a', '\x2', '\x2', 'L', '\x44', '\x3', '\x2', '\x2', 
		'\x2', 'L', 'M', '\x3', '\x2', '\x2', '\x2', 'M', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x14', '#', '&', '+', '\x30', '\x38', '\x41', 'H', 
		'L',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
