import 'package:flutter/material.dart';
import 'package:mobile/pages/registration.dart';

GlobalKey<FormState> _formKeyLogin = GlobalKey<FormState>();
bool _passwordVisible = false;

class Login extends StatefulWidget {
  const Login({super.key});

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  @override
  void initState() {
    super.initState();
    _passwordVisible = false;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Stack(
          children: [
            Container(
              decoration: const BoxDecoration(
              image: DecorationImage(
                  image: AssetImage('assets/images/login.jpg'),
                  fit: BoxFit.cover,
                  opacity: 0.8
                  )
                ),
            ),
            Container(
              alignment: Alignment.bottomCenter,
              padding: const EdgeInsets.all(25),
              child: SingleChildScrollView(
                child: Form(
                key: _formKeyLogin,
                child: Column(
                  children: [
                    const Align(
                      alignment: Alignment.centerLeft,
                      child: Text(
                        'Welcome back!',
                        textAlign: TextAlign.start,
                        style: TextStyle(
                            fontSize: 27, fontWeight: FontWeight.w500),
                      )),
                    const SizedBox(height: 40),
                    TextFormField(
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return "You can't leave this blank";
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

                          return null;
                        },
                        obscureText: !_passwordVisible,
                        decoration: InputDecoration(
                            labelText: 'Password',
                            labelStyle: const TextStyle(
                                color: Colors.black87, fontSize: 18),
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
                                size: 21,
                              ),
                            )),
                    ),
                    const SizedBox(height: 15),
                    TextButton(
                      onPressed: () {
                        if (_formKeyLogin.currentState!.validate()) {
                          ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(
                                  content: Text('Login form processing')));
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
                            'Login',
                            style:
                                TextStyle(color: Colors.black87, fontSize: 20),
                          ),
                        ),
                      )),
                    const SizedBox(height: 15),
                    const Text('No account?'),
                    TextButton(
                      onPressed: () {
                        Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => const Register()));
                      },
                      child: const Text(
                        'Register',
                        style: TextStyle(fontSize: 18, color: Colors.black87),
                      ))
                ],
                ),
              )
              )
            )
          ],
        )
    );
  }
}
