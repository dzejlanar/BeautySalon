import 'package:flutter/material.dart';

GlobalKey<FormState> _formKeyRegister = GlobalKey<FormState>();
bool _passwordVisible = false;

class Register extends StatefulWidget {
  const Register({super.key});

  @override
  _RegisterState createState() => _RegisterState();
}

class _RegisterState extends State<Register> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Stack(
      children: [
        Container(
          decoration: const BoxDecoration(
              image: DecorationImage(
                  image: AssetImage('assets/images/lonely-pink-flower-white-background.jpg'),
                  fit: BoxFit.cover,
                  opacity: 0.5)),
        ),
        SingleChildScrollView(
            child: Container(
          margin: const EdgeInsets.only(top: 30),
          padding: const EdgeInsets.all(25),
          color: Colors.transparent,
          child: Form(
            key: _formKeyRegister,
            child: Column(
              children: [
                const Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      'Create your account',
                      textAlign: TextAlign.start,
                      style:
                          TextStyle(fontSize: 27, fontWeight: FontWeight.w500),
                    )),
                const SizedBox(
                  height: 20,
                ),
                TextFormField(
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return "You can't leave this blank";
                    } else if (value.length < 4) {
                      return "Username must be at least 4 characters long";
                    }

                    return null;
                  },
                  decoration: const InputDecoration(
                      labelText: 'Username',
                      labelStyle:
                          TextStyle(color: Colors.black87, fontSize: 18),
                      enabledBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      focusedBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87))),
                ),
                TextFormField(
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return "You can't leave this blank";
                    } 

                    // dodati regex za email adresu?

                    return null;
                  },
                  keyboardType: TextInputType.emailAddress,
                  decoration: const InputDecoration(
                      labelText: 'Email Address',
                      labelStyle:
                          TextStyle(color: Colors.black87, fontSize: 18),
                      enabledBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      focusedBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87))),
                ),
                TextFormField(
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return "You can't leave this blank";
                    }

                    return null;
                  },
                  decoration: const InputDecoration(
                      labelText: 'First name',
                      labelStyle:
                          TextStyle(color: Colors.black87, fontSize: 18),
                      enabledBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      focusedBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87))),
                ),
                TextFormField(
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return "You can't leave this blank";
                    }

                    return null;
                  },
                  decoration: const InputDecoration(
                      labelText: 'Last name',
                      labelStyle:
                          TextStyle(color: Colors.black87, fontSize: 18),
                      enabledBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      focusedBorder: UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87))),
                ),
                TextFormField(
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return "You can't leave this blank";
                    } else if (value.length < 8) {
                      return "Password must be at least 8 characters long";
                    }

                    return null;
                  },
                  obscureText: !_passwordVisible,
                  decoration: InputDecoration(
                      labelText: 'Password',
                      labelStyle:
                          const TextStyle(color: Colors.black87, fontSize: 18),
                      enabledBorder: const UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      focusedBorder: const UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      suffixIcon: IconButton(
                        onPressed: () {
                          setState(() {
                            _passwordVisible = !_passwordVisible;
                          });
                        },
                        icon: Icon(
                          _passwordVisible
                              ? Icons.visibility
                              : Icons.visibility_off,
                          color: Colors.black87,
                          size: 18,
                        ),
                      )),
                ),
                TextFormField(
                  validator: (value) {
                    if (value == null || value.isEmpty) {
                      return "You can't leave this blank";
                    }
                    //dodati poredjenje passworda i password confirmation

                    return null;
                  },
                  obscureText: !_passwordVisible,
                  decoration: InputDecoration(
                      labelText: 'Password confirmation',
                      labelStyle:
                          const TextStyle(color: Colors.black87, fontSize: 18),
                      enabledBorder: const UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      focusedBorder: const UnderlineInputBorder(
                          borderSide: BorderSide(color: Colors.black87)),
                      suffixIcon: IconButton(
                        onPressed: () {
                          setState(() {
                            _passwordVisible = !_passwordVisible;
                          });
                        },
                        icon: Icon(
                          _passwordVisible
                              ? Icons.visibility
                              : Icons.visibility_off,
                          color: Colors.black87,
                          size: 18,
                        ),
                      )),
                ),
                //dodati date of birth i gender 
                const SizedBox(
                  height: 15,
                ),
                TextButton(
                    onPressed: () {
                      if (_formKeyRegister.currentState!.validate()) {
                        ScaffoldMessenger.of(context).showSnackBar(
                            const SnackBar(
                                content: Text('Register form processing')));
                      }
                    },
                    child: Container(
                      height: 45,
                      decoration: BoxDecoration(
                          color: Colors.white,
                          borderRadius: BorderRadius.circular(20),
                          border: Border.all(color: Colors.grey.withOpacity(0.3))),
                      child: const Center(
                        child: Text(
                          'Register',
                          style: TextStyle(color: Colors.black87, fontSize: 20),
                        ),
                      ),
                    )),
                const SizedBox(height: 15),
                const Text('Already have an account?'),
                TextButton(
                    onPressed: () {
                      Navigator.pop(context);
                    },
                    child: const Text(
                      'Login',
                      style: TextStyle(fontSize: 18, color: Colors.black87),
                    ))
              ],
            ),
          ),
        ))
      ],
    ));
  }
}
