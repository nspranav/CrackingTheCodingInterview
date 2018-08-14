Bit manipulation tips and tricks

x ^ 0s = x;
x ^ 1s = ~x;
x ^ x = 0s
x ^ ~x = 1;
x & 0s = 0;
x & 1s =1;
x & x =x;
x | x = x;
x | 0s = x;
x | 1s = 1s;

Two's complement and negative numbers

    All -ve numbers are represented as two's complement of its absolute value.
    It has 1 in its sign bit (left most bit) followed by its absolute value. 

    A 2's complement of a N-bit integer is complement
    of the number with respect to 2ᴺ⁻¹

    A 4 bit integer -3 is represented in the system as (1101) the left most one is the 
    sign bit ans the rest represent the 2's complement of absolute value of -3 which is 5.
    Derivation: abs(-3) = 3; 2's complement of 3 is (2ᴺ⁻¹ - 3) = 5   
    
Logical and Arithmetic Right Shift


    For a signed N bit integer an Arithmetic Right shift (>>) is quivalent to dividing by 2.

    Whereas for Logical Right shift we shift the bits by 1 position and replace the signed bit
    with 0. It is represented as >>>.

    For positive integers both the operations work similarly and work differently on -ve integers.

    Example 4 bit signed integer 3 and -3

    Arithmetic Right shift  3  0011 >> 1 = 0001
    Logical Right Shift 3 0011 >>> 1 = 0001

    Arithmetic Right shift -3 1011 >> 1 = 1001 = -1
    Logical Right shift -3  1011 >> 1 = 1101 = -5

    Important to remember that a sequence of 1s in a signed integer represents a -1
    11111111 = -1



Get Bit: Return true of the i th bit is 1 else false

    The idea is to shift 1 left by i so that the resulting number has 1 at i th position
    When we AND this number with the other number we get result as 0 if the ith bit is zero
    else non zero  

    boolean GetBit(int num, int  i){
        return (num & (1 << i) != 0);  
    }

Set Bit: set the bit at i th position

    In order to set bit at a position we need to OR with mask 000010000 (1 at the ith position)
    In oder to get the mask we shift 1 by i positions and then we OR with number

    int setBitAtPositonI(int num, int i){
        int mask = (1 << i);
        return num | mask;
    }


