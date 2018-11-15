grammar SicGrammar;


options {							
    language= CSharp2;
}


/*
 * Parser Rules
 */

programa: inicio (proposicion)+  fin;
inicio: ID SEP 'START' SEP NUM FINL;
fin: SEP 'END' (SEP? ID)? FINL?;
proposicion: ((ID SEP) | SEP)? (instruccion | directiva | RSUB) SEP? FINL;
instruccion:(formatuno | formatdos | ('+'? formatres));
RSUB:'RSUB';
directiva:('BYTE' SEP BYTEOP | ('BASE' SEP (ID|NUM)) | (TIPODIRECTIVA SEP NUM));
formatuno: INSTRUNO;
formatdos: (INSFDOSRR SEP REG SEP? ',' SEP? REG) | (INSFDOSRN SEP REG SEP? ',' SEP? NUMH) | ('SVC' SEP REG SEP? ',' SEP? NUM) | (INSFDOSR SEP REG);
formatres: INSTRES SEP MODIR? (ID | NUM) INDEX?;

/*
 * Lexer Rules
 */
INSTRUNO: ('FIX' | 'FLOAT' | 'HIO' | 'NORM' | 'SIO' | 'TIO'); 
INSFDOSRN: ('SHIFTR' | 'SHIFTL');
INSFDOSR: ('CLEAR' | 'TIXR');
INSFDOSRR: ('ADDR' | 'COMPR' | 'DIVR' | 'MULR' | 'RMO' | 'SUBR');
INSTRES:('ADD'|'ADDF'|'AND'|'COMP'|'COMPF'|'DIV'|'DIVF'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDB'|'LDCH'|'LDF'|'LDL'|'LDS'|'LDT'|'LDX'|'LPS'|'MUL'|'MULF'|'OR'|'RD'|'SSK'|'STA'|'STB'|'STCH'|'STF'|'STI'|'STL'|'STS'|'STSW'|'STT'|'STX'|'SUB'|'SUBF'|'TD'|'TIX'|'WD');
TIPODIRECTIVA: ('WORD'|'RESB'|'RESW');
BYTEOP : ('C\'' ID '\'' | 'X\'' NUMH '\'');
REG: ('A'|'X'|'L'|'B'|'S'|'T'|'F');
SEP:(' ' |'\t')+; 
NUM : ('0'..'9' | ('A' .. 'F'))+ ('h' | 'H')?;	
FINL: '\n';
NUMH: ('0'..'9' | ('A' .. 'F'))+;
NUMHH : NUMH ('h' | 'H' );
ID : ('a'..'z'|'A'..'Z')+;
INDEX : (',' ' '* 'X');
MODIR: '#' | '@';