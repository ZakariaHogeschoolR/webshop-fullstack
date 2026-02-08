import Navbar from "../Layout/Navbar";
import Footer from "../Layout/Footer";
import "../../Style/Login/SignUp.css";

const Login = () => {
  return (
    <div className="signup-page">
      <Navbar scrl = {true}/>

      <main className="signup-content">
        <form className="signup-form">
          <h2>Sign Up</h2>

          <div className="signup-field">
            <label>First name</label>
            <input className="signup-input" type="text" />
          </div>

          <div className="signup-field">
            <label>Last name</label>
            <input className="signup-input" type="text" />
          </div>

          <div className="signup-field signup-full">
            <label>Username</label>
            <input className="signup-input" type="text" />
          </div>

          <div className="signup-field">
            <label>Password</label>
            <input className="signup-input" type="password" />
          </div>

          <div className="signup-field">
            <label>Repeat password</label>
            <input className="signup-input" type="password" />
          </div>

          <div className="signup-field">
            <label>Email</label>
            <input className="signup-input" type="email" />
          </div>

          <div className="signup-field">
            <label>Repeat email</label>
            <input className="signup-input" type="email" />
          </div>

          <button className="signup-submit">Verzenden</button>
        </form>
      </main>

      <Footer />
    </div>
  );
};

export default Login;
