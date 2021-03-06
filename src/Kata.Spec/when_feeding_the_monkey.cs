﻿using System;
using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_feeding_the_monkey
    {
        static Monkey _systemUnderTest;
        
        Establish context = () => 
            _systemUnderTest = new Monkey();

        Because of = () => 
            _systemUnderTest.Eat("banana");

        It should_have_the_food_in_its_belly = () =>
            _systemUnderTest.Belly.Should().Contain("banana");
    }

    public class when_user_input_is_empty
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add(); };

        It should_return_zero = () => { _result.Should().Be(0); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_user_input_is_not_empty_and_one_number
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("3"); };

        It should_return_the_number = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_adding_two_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,3"); };

        It should_return_the_sum_of_both = () => { _result.Should().Be(4); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_adding_multiple_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,3,6"); };

        It should_return_the_sum_of_all_numbers = () => { _result.Should().Be(10); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_using_comma_and_new_line_as_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,2\n3"); };

        It should_return_the_sum = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_using_custom_char_as_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//@\n1@2@3"); };

        It should_return_the_sum = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_using_negative_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = Catch.Exception(() => _systemUnderTest.Add("1,2,-3,4")); };

        It should_throw_an_exception_listing_the_number = () => { _result.Message.Should().Be("negatives not allowed: -3"); };
        static Exception _result;
        static Calculator _systemUnderTest;
    }
    
    public class when_using_multiple_negative_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = Catch.Exception(() => _systemUnderTest.Add("1,2,-3,-4")); };

        It should_throw_an_exception_listing_the_numbers = () => { _result.Message.Should().Be("negatives not allowed: -3, -4"); };
        static Exception _result;
        static Calculator _systemUnderTest;
    }

    public class when_summing_with_a_multi_char_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//[***]\n12***3"); };
        
        It should_return_the_sum = () => { _result.Should().Be(15); };

    static Calculator _systemUnderTest;
    static int _result;

    }
    // Given the user input is multiple numbers with a custom multi-character delimiter when calculating the sum then it should return the sum of all the numbers. (example: “//[***]\n12***3” should return 6)
    // Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[][%]\n12%3” should return 6)
}