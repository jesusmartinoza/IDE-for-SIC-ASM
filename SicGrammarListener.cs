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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SicGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface ISicGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SicGrammarParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrograma([NotNull] SicGrammarParser.ProgramaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SicGrammarParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrograma([NotNull] SicGrammarParser.ProgramaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SicGrammarParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInicio([NotNull] SicGrammarParser.InicioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SicGrammarParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInicio([NotNull] SicGrammarParser.InicioContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SicGrammarParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFin([NotNull] SicGrammarParser.FinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SicGrammarParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFin([NotNull] SicGrammarParser.FinContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SicGrammarParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProposicion([NotNull] SicGrammarParser.ProposicionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SicGrammarParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProposicion([NotNull] SicGrammarParser.ProposicionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SicGrammarParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruccion([NotNull] SicGrammarParser.InstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SicGrammarParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruccion([NotNull] SicGrammarParser.InstruccionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SicGrammarParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectiva([NotNull] SicGrammarParser.DirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SicGrammarParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectiva([NotNull] SicGrammarParser.DirectivaContext context);
}
