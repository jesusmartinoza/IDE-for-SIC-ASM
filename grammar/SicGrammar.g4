grammar SicGrammar;


options {							
    language= CSharp2;
}


/*
 * Parser Rules
 */

programa: inicio (proposicion)+  fin;
inicio: ID 'START' (NUMD | NUMH ('h'|'H') ) FINL;
fin: SEP 'END' SEP ID? FINL?;
proposicion:( instruccion | directiva | RSUB) FINL;
instruccion: ID? SEP INSTRUCCIONES SEP opinstruccion ;
directiva: ID? SEP (BYTE | TIPODIRECTIVA SEP  OPDIRECTIVA) ;
opinstruccion: ID ',X'?  ;


/*
 * Lexer Rules
 */


INSTRUCCIONES :('ADD'|'AND'|'COMP'|'DIV'|'J'|'JEQ'|'JSUB'|'LDA'|'LDCH'|'LDL'|'LDX'|'MUL'|'OR'|'RD'|'STA'|'STCH'|'STL'|'STSW'|'STX'|'SUB'|'TD');
TIPODIRECTIVA: ('WORD'|'RESB'|'RESW');
BYTE 	:	'BYTE' SEP ('C\'' ID '\'' | 'X\'' NUMH '\'');
NUMD :('0'..'9');	
OPDIRECTIVA: NUMD | NUMH ('h' |'H');
FINL: '\n';
NUMH: (NUMD |'A' |'B' |'C' |'D' | 'E'| 'F' )+ ;
//NUMHH :NUMH ('h' | 'H' );
ID : (('a'..'z'|'A'..'Z')+ ('0'..'9')*)+;
SEP	:(' ' |'\t')+; 
RSUB 	: SEP 'RSUB' SEP? ;
//END: 'END';