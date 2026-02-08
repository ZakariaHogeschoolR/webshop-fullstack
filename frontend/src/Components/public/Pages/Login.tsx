import Navbar from "../Layout/Navbar";
import Footer from "../Layout/Footer";
import "../../Style/Login/Login.css";

const Login = () => {
  return (
    <div className="page">
      <Navbar scrl={true} />

      <main className="app-content">
        <form className="login-form">
          <h2>Login</h2>

          <label>Username</label>
          <input className="input" type="text" />

          <label>Password</label>
          <input className="input" type="password" />

          <button className="send">Verzenden</button>
        </form>
      </main>

      <Footer />
    </div>
  );
};

export default Login;
