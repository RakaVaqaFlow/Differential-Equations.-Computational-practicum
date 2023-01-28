# BS20-04 Computational Practicum Report Variant 11

## Introduction

There are many ways to solve differential equations of various kinds, but
they can be very difficult to solve using analytical methods. Then we can
use numerical methods that allow us to calculate the values of the function
close to the present.
In the practicum, we will consider the following numerical methods:
 Euler’s method
 Improved Euler’s method
 Runge-Kutta method

## Goals

Compare the result of calculations of numerical methods with the results
of an analytical solution. Determine the most accurate method.

## Tasks

1. Find the exact solution for the given initial value problem.
2. For the given IVP of the task implement in C# programming
language:
● Euler’s method,
● Improved Euler’s method,
● Runge-Kutta method
3. Implement the exact solution of an IVP in application.
4. Provide data visualization capability (charts plotting) in the user
interface.
5. Investigate the convergence of these numerical methods on different
grid sizes (provide the possibility of changing the number of grid steps).
6. Compare approximation errors of these methods plotting the
corresponding chart for different grid sizes (provide the possibility of
changing the range of grid steps).

## 1. Initial Value Problem

 𝑦′=𝑥𝑦−𝑥𝑦^3

𝑦( 0 )=√ 0. 5

𝑥∈( 0 , 3 )

### Answer:

𝑦=√𝑒𝑥^2/(1 +𝑒𝑥^2)

### Discontinuity points:


The particular function has no discontinuity points on the given
interval. However, 𝐶 does not exist if 𝑦 0 = 0

## 2. Programming Part


You can see the entire program code at the link:
https://github.com/RakaVaqaFlow/Computational_practicum
For the implementation of the methods, I chose the C # programming
language, since it has the necessary functionality (complex mathematical
operations) and is easy to learn. To implement the interface, I used the
Windows.Forms tool, since it is very powerful and easy to learn.

### Structure of the program

This implementation is independent of a specific example. We can use
this scheme for all options, it is enough just to inherit our class from the
DifferentialEquation class (in our case variant 11 – MyDifferentialEquation
class).


### Some implementation features


In my implementation, if you want to add a new numerical method, you
just need to inherit a new class from the NumericalMethod class and
redefine the function calcY(). For example, implementation of
EulerMethod class (fig. 7):


Also, if you want to see a solution for another varient, inherit the new
class from the DifferentialEquation class and override the following
methods:

* double calcDerivative(double x, double y)
* void calcExactSolution()
* double[] findDiscontinuityPoints()
For example, my variant 11 has structure (fig. 8):

## 3. Method analysis


The graph shows (fig. 3) that numerical methods give a result close
enough to the real one.
The plot of the local error (fig. 4) shows that the error of the Euler’s
method at small values of 𝑥 is less than that of others (perhaps it depends
on the function, since this is not observed for other variants), however,
closer to the right border, the Runge-Kutta method and the Improved
Euler’s method are more accurate. If we look at the graph of the global
error (fig. 5), we can see that the Runge-Kutta method is indeed more
accurate than the Improved Euler’s method and Improved Euler’s method
more accurate than the Euler’s method.

## 4. Conclusion


The Runge-Kutta method is the most accurate. The improved Euler
method is fairly accurate. Euler's method is less accurate


