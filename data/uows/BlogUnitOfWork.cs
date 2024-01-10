using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.repositories;
using data.tables;
namespace data.uows
{
    public class BlogUnitOfWork
    {
        private BlogContext _context;

        public BlogUnitOfWork() {
            _context = new BlogContext();
        }
        private Repository<Blog> _blogRepository;
        private Repository<Post> _postRepository;
        private Repository<Krediler> _kredilerRepository;
        private Repository<hava_durumu> _hava_durumuRepository;
        public Repository<hava_durumu> hava_durumuRepository {
            get{
                if (_hava_durumuRepository == null) {
                    _hava_durumuRepository = new Repository<hava_durumu>(_context);
                }
                return _hava_durumuRepository;
            }
        }
        public Repository<Krediler> kredilerRepository {
            get {
                if (_kredilerRepository == null) {
                    _kredilerRepository = new Repository<Krediler>(_context);
                }
                return _kredilerRepository;
            }
        }
        public Repository<Blog> blogRepository {
            get {
                if (_blogRepository == null) {
                    _blogRepository = new Repository<Blog>(_context);
                }
                return _blogRepository;
            }
        }
        public Repository<Post> postRepository {
            get {
                if (_postRepository == null) {
                    _postRepository = new Repository<Post>(_context);
                }
                return _postRepository;
            }
        }

    }
}