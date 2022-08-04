#include <stdio.h>

void print_char_array(char *function_name, char *array_to_print)
{
    printf("%s : %s\n", function_name, array_to_print);
}

/*
    Implement your logic inside this method ONLY
*/
void secp_logic(char *array_to_manipulate)
{
    /*
        Start implementation
    */

    /*
        End implementation
    */
    print_char_array("Post-logic", array_to_manipulate);
    printf("--------------------------------------------------------\n");
    //
    return;
}

void test_mixed_case()
{
    char program[] = {'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', ' ', 'E', 'n', 'g', 'i', 'n', 'e', 'e', 'r', 'i', 'n', 'g', ' ', 'C', 'a', 'r', 'e', 'e', 'r', ' ', 'P', 'r', 'o', 'g', 'r', 'a', 'm', '\0'};
    //
    print_char_array("Pre -logic", program);
    //
    secp_logic(program);
    //
    return;
}

void test_lower_case()
{
    char program[] = {'g', 'r', 'e', 'e', 't', 'i', 'n', 'g', 's', ' ', 'f', 'r', 'o', 'm', ' ', 'b', 'y', 't', 'e', 'r', 'i', 'd', 'g', 'e', '\0'};
    //
    print_char_array("Pre -logic", program);
    //
    secp_logic(program);
    //
    return;
}

int main()
{
    test_mixed_case();
    test_lower_case();
    //
    return 0;
}