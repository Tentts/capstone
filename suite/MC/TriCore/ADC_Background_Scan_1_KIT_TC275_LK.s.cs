# CS_ARCH_TRICORE, CS_MODE_TRICORE, None
0x40,0x4f = mov.aa %a15, %a4
0x02,0x48 = mov %d8, %d4
0x02,0x29 = mov %d9, %d2
0x02,0x94 = mov %d4, %d9
0x3c,0x0b = j 80001c56 <IfxVadc_disableAccess+0x3c>
0x02,0x94 = mov %d4, %d9
0xa6,0x0f = or %d15, %d0
0xa6,0x10 = or %d0, %d1
0x82,0x11 = mov %d1, 1
0xda,0x20 = mov %d15, 32
0x82,0x10 = mov %d0, 1
0x00,0x90 = ret
0x09,0xf0,0x0c,0x29 = ld.w %d0, [%a15]140
0x8f,0xf8,0x01,0xf1 = and %d15, %d8, 31
0x0f,0xf1,0x10,0x10 = sha %d1, %d1, %d15
0x89,0xf0,0x0c,0x29 = st.w [%a15]140, %d0
0x6d,0xff,0xb3,0xff = call 80001bbe <IfxScuWdt_setSafetyEndinit>
0x6d,0xff,0x02,0xfe = call 8000182a <IfxScuWdt_clearSafetyEndinit>
0x7f,0xf8,0x0b,0x80 = jge.u %d8, %d15, 80001c42 <IfxVadc_disableAccess+0x28>
0x89,0xff,0x08,0x29 = st.w [%a15]136, %d15
0x0f,0x80,0x10,0x00 = sha %d0, %d0, %d8
0x09,0xff,0x08,0x29 = ld.w %d15, [%a15]136
