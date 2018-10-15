.586
.model flat,stdcall
.stack 4096

extrn	ExitProcess@4	:	proc
extrn	MessageBoxA@16	:	proc

.data
	msg_txt db	"Hello World, this is a sample",0
	msg_caption db "Test Program",0

.code
	main:nop

		push	0
	
		lea eax,msg_caption
		push eax

		lea eax,msg_txt
		push eax

		push 0

		call MessageBoxA@16

		push 0
		call ExitProcess@4

	end main