# include <iostream> // directive which is processed by the preprocessor, this one in particular calls for the iostream file for the input/output library
using namespace std; // this imports the std namespace into our program so we don't have to specify for each statement

int main() {
  cout << "Hello World"; // this is the equivalent of std::cout << "Hello World"; but our namespace declaration makes it so this isn't required each time
  return 0; // this signifies program execution is complete, if left out, C++ will add it automatically
}
